using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace memoryManagement
{
    public class Process
    {
        public string processname;
        public int numofsegments;
        public List<SegmentTable> storedtable = new List<SegmentTable>();
        public List<Segment> listofsegments = new List<Segment>();

        public Process(string Pname, int Snum)
        {
            processname = Pname;
            numofsegments = Snum;
        }
        public Process()
        {
            processname = null;
            numofsegments = 0;
        }
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

        public Segment(string segmentname, int size)
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
            startingaddress = a;//satrting address l 2wl
            size = b;

        }
    }

    public class SegmentTable
    {
        public int indexofsegment;
        public string segmentname;
        public int baseaddress;
        public int limit;

        public SegmentTable()
        {
            indexofsegment = 0;
            segmentname = "name";
            baseaddress = 0;
            limit = 0;
        }

        public SegmentTable(int a, string name, int b, int c)
        {
            indexofsegment = a;
            segmentname = name;
            baseaddress = b;
            limit = c;

        }
    }

    public class FinalTable
    {
        public bool drawnUp;//new 
        public int nextLocationY;
        public string label;
        public string id;
        public int startAddress;
        public int endAddress;
        public int size;

        public FinalTable()
        {
            drawnUp = false;
            nextLocationY = 0;
            label = "0";
            id = "0";
            startAddress = 0;
            endAddress = 0;
            size = 0;
        }

        public FinalTable(string label, string id, int s, int e)
        {
            drawnUp = false;
            nextLocationY = 0;
            this.label = label;
            this.id = id;
            startAddress = s;
            endAddress = e;
            this.size = e - s;
        }
    }

    public static class Management
    {
        public static int totalmemorysize;
        public static string allocationType=null;
        public static int startingofmemory = 0;
        public static List<Process> inputprocesses = new List<Process>(); //I have no idea why static is needed
        public static List<Hole> inputholes = new List<Hole>();
        public static List<Process> pendingprocess = new List<Process>();
        public static List<FinalTable> finalOutput = new List<FinalTable>();


        public static void Sortholes()
        {
            inputholes = inputholes.OrderBy(s => s.startingaddress).ToList();
        }
        //this means we always have to always update list of holes
       public static void BindingHoles()
        {
            for (int i = 0; i < finalOutput.Count - 1; i++)
            {
                if (finalOutput[i].label == finalOutput[i + 1].label && finalOutput[i].label == "holes")
                {
                    finalOutput[i].endAddress = finalOutput[i + 1].endAddress;
                    finalOutput[i].size = finalOutput[i].endAddress - finalOutput[i].startAddress;
                    finalOutput.RemoveAt(i + 1);
                }

            }
        }

        public static void Firstinput()
        {
            int arranger = 0;
            int j = 0;

            while (j < inputholes.Count) //condition y5lene a5ls lma l a5ls lma l holes t5ls
            {
                if (arranger < inputholes[j].startingaddress)
                {
                    finalOutput.Add(new FinalTable("allocated" + j.ToString(), "unknownprocess" + j, arranger, inputholes[j].startingaddress));
                    Process p = new Process();
                    p.processname = "allocated" + j;
                    p.numofsegments = 1;
                    p.listofsegments.Add(new Segment("unknownprocess" + j, arranger - inputholes[j].startingaddress));
                    inputprocesses.Add(p);

                }


                finalOutput.Add(new FinalTable("holes", "HOLE" + j, inputholes[j].startingaddress, inputholes[j].startingaddress + inputholes[j].size));
                arranger = inputholes[j].startingaddress + inputholes[j].size;
                j++;

            }
            if (arranger != totalmemorysize)
                finalOutput.Add(new FinalTable("allocated" + j, "unknownprocess" + j, arranger, totalmemorysize));
            Process l = new Process();
            l.processname = "allocated" + j;
            l.numofsegments = 1;
            l.listofsegments.Add(new Segment("unknownprocess" + j, arranger - totalmemorysize));
            inputprocesses.Add(l);

        }

        public static void Firstfit(Process p)
        {

            for (int i = 0; i < p.listofsegments.Count; i++)
            {
                for (int j = 0; j < finalOutput.Count; j++)
                {
                    if (p.listofsegments[i].size < (finalOutput[j].endAddress - finalOutput[j].startAddress) && finalOutput[j].label == "holes")
                    {
                        int start, end;

                        start = finalOutput[j].startAddress;
                        end = finalOutput[j].endAddress;
                        finalOutput.Remove(finalOutput[j]);
                        finalOutput.Insert(j, new FinalTable(p.processname, p.listofsegments[i].segmentname, start, (start + p.listofsegments[i].size)));

                        p.storedtable.Add(new SegmentTable(i, p.listofsegments[i].segmentname, start, p.listofsegments[i].size));

                        start += p.listofsegments[i].size;
                        finalOutput.Insert(j + 1, new FinalTable("holes", "HOLE" + (j).ToString(), start, end));

                        break;
                    }
                    else if (p.listofsegments[i].size == (finalOutput[j].endAddress - finalOutput[j].startAddress) && finalOutput[j].label == "holes")

                    {
                        int start, end;

                        start = finalOutput[j].startAddress;
                        end = finalOutput[j].endAddress;
                        finalOutput.Remove(finalOutput[j]);
                        finalOutput.Insert(j, new FinalTable(p.processname, p.listofsegments[i].segmentname, start, (start + p.listofsegments[i].size)));

                        p.storedtable.Add(new SegmentTable(i, p.listofsegments[i].segmentname, start, p.listofsegments[i].size));
                        break;

                    }
                }
            }
            inputprocesses.Add(p);
        }

        public static void Bestfit(Process p)
        {

            p.listofsegments = p.listofsegments.OrderBy(s => s.size).ToList();
            for (int i = 0; i < p.listofsegments.Count; i++)
            {
                for (int j = 0; j < finalOutput.Count; j++)
                {
                    finalOutput = finalOutput.OrderBy(s => (s.endAddress - s.startAddress)).ToList();

                    if (p.listofsegments[i].size < (finalOutput[j].endAddress - finalOutput[j].startAddress) && finalOutput[j].label == "holes")
                    {
                        int start, end;

                        start = finalOutput[j].startAddress;
                        end = finalOutput[j].endAddress;
                        finalOutput.Remove(finalOutput[j]);
                        finalOutput.Insert(j, new FinalTable(p.processname, p.listofsegments[i].segmentname, start, (start + p.listofsegments[i].size)));

                        p.storedtable.Add(new SegmentTable(i, p.listofsegments[i].segmentname, start, p.listofsegments[i].size));

                        start += p.listofsegments[i].size;
                        finalOutput.Insert(j + 1, new FinalTable("holes", "HOLE" + (j).ToString(), start, end));

                        break;
                    }
                    else if (p.listofsegments[i].size == (finalOutput[j].endAddress - finalOutput[j].startAddress) && finalOutput[j].label == "holes")

                    {
                        int start, end;

                        start = finalOutput[j].startAddress;
                        end = finalOutput[j].endAddress;
                        finalOutput.Remove(finalOutput[j]);
                        finalOutput.Insert(j, new FinalTable(p.processname, p.listofsegments[i].segmentname, start, (start + p.listofsegments[i].size)));

                        p.storedtable.Add(new SegmentTable(i, p.listofsegments[i].segmentname, start, p.listofsegments[i].size));

                        break;

                    }
                }
            }
            // reem 2alt dh 
            finalOutput = finalOutput.OrderBy(s => s.startAddress).ToList();
            inputprocesses.Add(p);
        }

        public static void Worstfit(Process p)
        {


            for (int i = 0; i < p.listofsegments.Count; i++)
            {
                for (int j = 0; j < finalOutput.Count; j++)
                {
                    finalOutput = finalOutput.OrderByDescending(s => (s.endAddress - s.startAddress)).ToList();

                    if (p.listofsegments[i].size < (finalOutput[j].endAddress - finalOutput[j].startAddress) && finalOutput[j].label == "holes")
                    {
                        int start, end;

                        start = finalOutput[j].startAddress;
                        end = finalOutput[j].endAddress;
                        finalOutput.Remove(finalOutput[j]);
                        finalOutput.Insert(j, new FinalTable(p.processname, p.listofsegments[i].segmentname, start, (start + p.listofsegments[i].size)));

                        p.storedtable.Add(new SegmentTable(i, p.listofsegments[i].segmentname, start, p.listofsegments[i].size));

                        start += p.listofsegments[i].size;
                        finalOutput.Insert(j + 1, new FinalTable("holes", " HOLE" + (j).ToString(), start, end));

                        break;
                    }
                    else if (p.listofsegments[i].size == (finalOutput[j].endAddress - finalOutput[j].startAddress) && finalOutput[j].label == "holes")

                    {
                        int start, end;

                        start = finalOutput[j].startAddress;
                        end = finalOutput[j].endAddress;
                        finalOutput.Remove(finalOutput[j]);
                        finalOutput.Insert(j, new FinalTable(p.processname, p.listofsegments[i].segmentname, start, (start + p.listofsegments[i].size)));

                        p.storedtable.Add(new SegmentTable(i, p.listofsegments[i].segmentname, start, p.listofsegments[i].size));

                        break;

                    }
                }

            }
            finalOutput = finalOutput.OrderBy(s => s.startAddress).ToList();
            inputprocesses.Add(p);
        }

        public static bool Isfit(Process a, string typeofallocation)
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
                if (typeofallocation == "first fit")
                {
                    for (int i = 0; i < segmentsforchecking.Count; i++)
                    {
                        for (int j = 0; j < listforchecking.Count; j++)
                        {

                            if (listforchecking[j].label == "holes" && listforchecking[j].size == segmentsforchecking[i].size)
                            {
                                listforchecking.RemoveAt(j);
                                check = true;
                                break;

                            }
                            if (listforchecking[j].label == "holes" && listforchecking[j].size > segmentsforchecking[i].size)
                            {

                                listforchecking.Add(new FinalTable("holes", "new hole" + j, listforchecking[j].startAddress + segmentsforchecking[i].size, listforchecking[j].endAddress));
                                listforchecking.RemoveAt(j);
                                listforchecking = listforchecking.OrderBy(s => s.startAddress).ToList();
                                check = true;
                                break;

                            }
                            check = false;
                        }
                        if (check == false)
                        {
                            pendingprocess.Add(a);
                            return false;


                        }



                    }
                }
                if (typeofallocation == "worst fit")
                {
                    // segmentsforchecking = segmentsforchecking.OrderByDescending(s => s.size).ToList();
                    for (int i = 0; i < segmentsforchecking.Count; i++)
                    {
                        for (int j = 0; j < listforchecking.Count; j++)
                        {
                            listforchecking = listforchecking.OrderByDescending(s => s.size).ToList();

                            if (listforchecking[j].label == "holes" && listforchecking[j].size == segmentsforchecking[i].size)
                            {
                                listforchecking.RemoveAt(j);
                                check = true;
                                break;

                            }
                            if (listforchecking[j].label == "holes" && listforchecking[j].size > segmentsforchecking[i].size)
                            {

                                listforchecking.Add(new FinalTable("holes", "new hole" + j, listforchecking[j].startAddress + segmentsforchecking[i].size, listforchecking[j].endAddress));
                                listforchecking.RemoveAt(j);
                                check = true;
                                break;

                            }
                            check = false;
                        }
                        if (check == false)
                        {
                            pendingprocess.Add(a);
                            return false;


                        }



                    }
                }
                if (typeofallocation == "best fit")
                {
                    // listforchecking = listforchecking.OrderBy(s => s.size).ToList();
                    //  segmentsforchecking = segmentsforchecking.OrderByDescending(s => s.size).ToList();
                    for (int i = 0; i < segmentsforchecking.Count; i++)
                    {
                        for (int j = 0; j < listforchecking.Count; j++)
                        {
                            listforchecking = listforchecking.OrderBy(s => s.size).ToList();

                            if (listforchecking[j].label == "holes" && listforchecking[j].size == segmentsforchecking[i].size)
                            {
                                listforchecking.RemoveAt(j);
                                check = true;
                                break;

                            }
                            if (listforchecking[j].label == "holes" && listforchecking[j].size > segmentsforchecking[i].size)
                            {

                                listforchecking.Add(new FinalTable("holes", "new hole" + j, listforchecking[j].startAddress + segmentsforchecking[i].size, listforchecking[j].endAddress));
                                listforchecking.RemoveAt(j);
                                check = true;
                                break;

                            }
                            check = false;
                        }
                        if (check == false)
                        {
                            pendingprocess.Add(a);
                            return false;


                        }



                    }
                }

                if (check == true)
                { return true; }
                else
                    return false;

            }
            else
            {
                 pendingprocess.Add(a);
                return false;

            }
        }

        public static void deallocation(string deallocProcessName)
        {

            Process itemToRemove = Management.inputprocesses.Single(r => r.processname == deallocProcessName);
            //remove process's segments from holes list 
            int idx;
            for (int i = 0; i < itemToRemove.numofsegments; i++)
            {
                idx = finalOutput.FindIndex(r => r.id == (itemToRemove.listofsegments[i].segmentname));
                finalOutput[idx].label = "holes";
                finalOutput[idx].id = "HOLE";

            }
            //remove it from list of process
            Management.inputprocesses.Remove(itemToRemove);

        }
    }    
}
