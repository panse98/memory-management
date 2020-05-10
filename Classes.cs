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
            this.size = e - s;
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

        public bool Isfit(Process a, string typeofallocation)
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
                return false;

            }
        }

        public void Firstfit(Process p)

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
                        finalOutput.Insert(j, new FinalTable(p.processname, p.listofsegments[i].segmentname, start/*finalOutput[j].startAddress*/, (start/*finalOutput[j].startAddress*/+ p.listofsegments[i].size)));
                        // finalOutput.Add(new FinalTable(p.processname, p.listofsegments[i].segmentname, start/*finalOutput[j].startAddress*/, (start/*finalOutput[j].startAddress*/+p.listofsegments[i].size )));
                        start += p.listofsegments[i].size;
                        finalOutput.Insert(j + 1, new FinalTable("holes", " HOLE" + (j).ToString(), start /*finalOutput[j].startAddress*//* += p.listofsegments[i].size*/, end /*finalOutput[j].endAddress*/));

                        break;
                    }
                    else if (p.listofsegments[i].size == (finalOutput[j].endAddress - finalOutput[j].startAddress) && finalOutput[j].label == "holes")

                    {
                        int start, end;

                        start = finalOutput[j].startAddress;
                        end = finalOutput[j].endAddress;
                        finalOutput.Remove(finalOutput[j]);
                        finalOutput.Insert(j, new FinalTable(p.processname, p.listofsegments[i].segmentname, start/*finalOutput[j].startAddress*/, (start/*finalOutput[j].startAddress*/+ p.listofsegments[i].size)));


                        break;

                    }
                }
            }
        }

        public void Bestfit(Process p)
        {

            //   var group= from s in finalOutput
            //                    group s by s.label = "holes";

            //group = group.OrderBy(s=>s ).ToList();
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


                        break;

                    }
                }
            }
            // reem 2alt dh 
            finalOutput = finalOutput.OrderBy(s => s.startAddress).ToList();
        }

        public void Worstfit(Process p)
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


                        break;

                    }
                }

            }
            finalOutput = finalOutput.OrderBy(s => s.startAddress).ToList();

        }

        public void Setsegmenttable()   // baktb bs fkra gatly ( 3arfa enha  3 looops w msh sah kda ) 
        {
            for (int i = 0; i < inputprocesses.Count; i++)
            {
                for (int j = 0; j < finalOutput.Count; j++)
                {
                    for (int k = 0; k < inputprocesses[i].listofsegments.Count; k++)
                    {
                        if (inputprocesses[i].processname + inputprocesses[i].listofsegments[k].segmentname == finalOutput[j].id)
                        {
                            inputprocesses[i].storedtable.Add(new SegmentTable(inputprocesses[i].listofsegments[k].segmentname, finalOutput[j].startAddress, finalOutput[j].size));
                        }

                    }
                }
                inputprocesses[i].storedtable = inputprocesses[i].storedtable.OrderBy(s => s.baseaddress).ToList();
            }


        }

        public void Showsegmenttable(string a) // bgrb bs m3rfsh sah wla la hn7tg n testha 
        {
            for (int i = 0; i < inputprocesses.Count; i++)
            {
                if (a == inputprocesses[i].processname)
                {
                    for (int j = 0; j < inputprocesses[i].storedtable.Count; j++) // fel gui han3ml table or msg box
                    {
                        Console.WriteLine("{0}:base={1},limit={2}", inputprocesses[i].storedtable[j].indexofsegment, inputprocesses[i].storedtable[j].baseaddress, inputprocesses[i].storedtable[j].limit);
                    }
                }
            }
        }
    }

}

