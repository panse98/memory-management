using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace memory_management_project
{
    public class Process
    {
        public string processname;
        public int numofsegments;
        public List<SegmentTable> storedtable = new List<SegmentTable>();
        public List<Segment> listofsegments = new List<Segment>();
    }
    public class Segment
    {
        public string segmentname;
        public int size;

        public Segment()
        {
            segmentname = "0";
            size = 0;
        }

        public Segment(int size, string segmentname)
        {
            this.size = size;
            this.segmentname = segmentname;
        }
    }
    public class Hole
    {
        public int startingaddress;
        public int size;

        public Hole()
        {
            size = 0;
            startingaddress = 0;
        }

        public Hole(int a, int b)
        {
            size = a;
            startingaddress = b;

        }
    }

    public class SegmentTable
    {
        public string indexofsegment;
        public int baseaddress;
        public int limit;

        public SegmentTable()
        {
            indexofsegment = "0";
            baseaddress = 0;
            limit = 0;
        }

        public SegmentTable(string a, int b, int c)
        {
            indexofsegment = a;
            baseaddress = b;
            limit = c;

        }
    }

    public class FinalTable
    {
        public string label;
        public string id;
        public int startAddress;
        public int endAddress;
        public int size;

        public FinalTable()
        {

            label = "0";
            id = "0";
            startAddress = 0;
            endAddress = 0;
            size = 0;
        }

        public FinalTable(string label, string id, int s, int e)
        {
            this.label = label;
            this.id = id;
            startAddress = s;
            endAddress = e;
            this.size = s - e;
        }
    }

    public class Management
    {
        public static int totalmemorysize;
        public static int startingofmemory = 0;
        public static List<Process> inputprocesses = new List<Process>(); //I have no idea why static is needed
        public static List<Hole> inputholes = new List<Hole>();
        public static List<Process> pendingprocess = new List<Process>();
        public static List<FinalTable> finalOutput = new List<FinalTable>();
        public void Sortholes()
        {
            inputholes = inputholes.OrderBy(s => s.startingaddress).ToList();
        }
        //this means we always have to always update list of holes
        public void BindingHoles()
        {
            for (int i = 0; i < finalOutput.Count - 1; i++)
            {
                if (finalOutput[i].label == finalOutput[i + 1].label && finalOutput[i].label == "holes")
                {
                    finalOutput[i].endAddress = finalOutput[i + 1].endAddress;
                    finalOutput.RemoveAt(i + 1);
                }

            }
        }

        public void Firstinput()
        {
            int arranger = 0;
            int j = 0;

            while (j < inputholes.Count) //condition y5lene a5ls lma l a5ls lma l holes t5ls
            {
                if (arranger < inputholes[j].startingaddress)
                {
                    finalOutput.Add(new FinalTable("allocated", "unknownprocess" + j, arranger, inputholes[j].startingaddress));
                }


                finalOutput.Add(new FinalTable("holes", "HOLE" + j, inputholes[j].startingaddress, inputholes[j].startingaddress + inputholes[j].size));
                arranger = inputholes[j].startingaddress + inputholes[j].size;
                j++;

            }
            if (arranger != totalmemorysize)
                finalOutput.Add(new FinalTable("allocated", "unknownprocess" + j, arranger, totalmemorysize));
        }

        public bool Isfit(Process a)
        {
            int sizeofholes = 0;
            int sizeofsegments = 0;
            bool check = false;
            List<Segment> segmentsforchecking = a.listofsegments; //3mlt kda 3shan my7slsh overwrite 3al list of segments ld5laly aslun lkolo byghyr feha
            List<FinalTable> listforchecking = finalOutput.ToList();

            for (int i = 0; i < finalOutput.Count; i++)
            {
                if (finalOutput[i].label == "holes")
                    sizeofholes += finalOutput[i].size;

            }

            for (int i = 0; i < a.numofsegments; i++)
            {
                sizeofsegments += a.listofsegments[i].size;
            }


            if (sizeofholes >= sizeofsegments)
            {
                for (int i = 0; i < segmentsforchecking.Count; i++)
                {
                    for (int j = 0; j < listforchecking.Count; j++)
                    {

                        if (listforchecking[j].label == "holes" && listforchecking[j].size >= segmentsforchecking[i].size)
                        {
                            listforchecking.RemoveAt(j);
                            check = true;
                            break;

                        }
                    }
                    if (check == false)
                    {
                        pendingprocess.Add(a);
                        return false;
                    }



                }

                return true;
            }
            else
            {
                return false;

            }
        }


    }
}
