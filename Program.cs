﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // classes mbd2ya kda bs


    class Program
    {
        public static int totalmemorysize;
        public static int startingofmemory = 0;
        // public static int endofmemory = totalmemorysize;
        public static List<Process> inputprocesses = new List<Process>(); //I have no idea why static is needed
        public static List<Hole> inputholes = new List<Hole>();
        public static List<Process> pendingprocess = new List<Process>();
        public static List<FinalTable> finalOutput = new List<FinalTable>();
        //List<Hole> inputholes = new List<Hole>();
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

        // class reem
        //public class FinalTable
        //{
        //    public string label;
        //    public string id;
        //    public int startAddress;
        //    public int endAddress;

        //    public FinalTable()
        //    {
        //        string label ;
        //        string id ;
        //        int startAddress ;
        //        int endAddress;
        //    }
        //        public FinalTable(string t, string f, int s, int e)
        //    {
        //        label = t;
        //        id = f;
        //        startAddress = s;
        //        endAddress = e;
        //    }
        //}
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
                size = endAddress - startAddress;
            }

            public FinalTable(string label, string id, int s, int e)
            {
                this.label = label;// hole wala allocated
                this.id = id;// asm l segment l d5l msln p1 seg 1
                startAddress = s;
                endAddress = e;
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
        public class Process
        {
            public string processname;
            public int numofsegments;
            // public List<SegmentTable> storedtable = new List<SegmentTable>();
            public List<Segment> listofsegments = new List<Segment>();

        }
        public class Management
        {

            //string allocationtypes;

            //int totalmemorysize;
            //List<Process> inputprocesses = new List<Process>();
            // List<Hole> inputholes = new List<Hole>();

            //List<Process> pendingprocess = new List<Process>();

            public void Sortholes()
            {
                inputholes.OrderBy(s => s.startingaddress);
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

                for (int i = 0; i < inputholes.Count(); i++)
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
                if (sizeofholes >= sizeofsegments)
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
                            finalOutput.Insert(j + 1, new FinalTable("hole", " HOLE" + (j).ToString(), start /*finalOutput[j].startAddress*//* += p.listofsegments[i].size*/, end /*finalOutput[j].endAddress*/));
                            //finalOutput.Add(new FinalTable("hole", " HOLE"+(j).ToString(),start /*finalOutput[j].startAddress*//* += p.listofsegments[i].size*/,end /*finalOutput[j].endAddress*/));

                          //  finalOutput = finalOutput.OrderBy(s => s.startAddress).ToList();

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

            }



        }

        static void Main(string[] args)
        {
            //memory size
            totalmemorysize = Int32.Parse(Console.ReadLine());
            string processnames = Console.ReadLine();
            //holes
            Hole hole1 = new Hole();
            hole1.size = 3;
            hole1.startingaddress = 1;
            inputholes.Add(hole1);

            Hole hole2 = new Hole();
            hole2.size = 7;
            hole2.startingaddress = 5;
            inputholes.Add(hole2);

            //Hole hole3 = new Hole();
            //hole3.size = 3;
            //hole3.startingaddress = 20;
            //inputholes.Add(hole3);

            Management alaa = new Management();
            alaa.Firstinput();

          
            Process reem = new Process();
            reem.processname = processnames;
            reem.numofsegments = 2;
            reem.listofsegments.Add(new Segment(2, "s1"));
            reem.listofsegments.Add(new Segment(6, "s2"));
           //  alaa.Isfit(reem);

            alaa.Firstfit(reem);
            foreach (var x in finalOutput)
                Console.WriteLine(" {0}  {1} start {2} end {3}",x.label , x.id, x.startAddress, x.endAddress);

            Console.ReadKey();

        }
    }

}