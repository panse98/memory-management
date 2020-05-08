using System;
using System.Collections.Generic;
using System.Text;

namespace memory_management_project
{
    class Process
    {
        public string processname;
        public int numofsegments;
        public List<SegmentTable> storedtable = new List<SegmentTable>();
        public List<Segment> listofsegments = new List<Segment>();
    }
    class Segment
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
    class Hole
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

    class SegmentTable
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
}
