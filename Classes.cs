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
        public int indexofsegment;
        public int baseaddress;
        public int limit;

        public SegmentTable()
        {
            indexofsegment = 0;
            baseaddress = 0;
            limit = 0;
        }

        public SegmentTable(int a, int b, int c)
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
            this.size = startAddress - endAddress;
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

        public void SegmentTable()
        {

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
                finalOutput.Add(new FinalTable("allocated", "unknownprocess" + j + 1, arranger, totalmemorysize));
        }

        public void Isfit(Process a)
        {
            int sizeofholes = 0;
            int sizeofsegments = 0;

            for (int i = 0; i < inputholes.Count; i++)
            {
                sizeofholes += inputholes[i].size;
                //   Console.WriteLine("holesssssssss");
            }

            for (int i = 0; i < a.numofsegments; i++)
            {
                sizeofsegments += a.listofsegments[i].size;
                //  Console.WriteLine("segments");
            }

            Hole check;
            if (sizeofholes > sizeofsegments)
            {
                // Console.WriteLine("enteringg");
                for (int i = 0; i < a.listofsegments.Count; i++)
                {
                    int r = a.listofsegments[i].size;
                    check = inputholes.Find(x => x.size >= r);
                    Console.WriteLine("calcu");
                    if (check.size == -1)
                    {
                        Console.WriteLine("This process can't fit in memory"); //lma n link han call function deallocate
                        pendingprocess.Add(a);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("This process will fit in memory");   // hanshelha lma nlink bs han-test beeha now
                    }
                }

            }
            else
            {
                Console.WriteLine("This process can't fit in memory"); //lma n link han call function deallocate
            }
        }


    }
}
