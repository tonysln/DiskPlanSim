using System;
using System.Collections.Generic;
using System.Text;

namespace DiskPlanSim
{
    class Simulaator
    {
        public List<int> Sectors { get; } // KAS ON KORDUVAD?
        public List<int> Result { get; set; }
        public int Path { get; set; }
        private int head;

        public Simulaator()
        {
            this.Sectors = new List<int>();
            this.Result = new List<int>();
            this.Path = 0;
            this.head = 10;
        }

        public void FCFS()
        {
            // Starting at sector 10
            Result.Add(10);
            // All other positions are in the order they arrived
            for (int i = 0; i < Sectors.Count; i++)
            {
                Result.Add(Sectors[i]);
                Path += Math.Abs(head - Sectors[i]);
                head = Sectors[i];
            }
        }

        public void SSTF()
        {
            List<int> SectorsCopy = new List<int>(Sectors);
            while (SectorsCopy.Count > 0)
            {
                // Find closest position
                int closest = 5000;
                int index = 0;
                for (int j = 0; j < SectorsCopy.Count; j++)
                {
                    int distance = Math.Abs(SectorsCopy[j] - head);
                    int bestDist = Math.Abs(head - closest);
                    // Compare currently found distance to best one
                    if ((distance < bestDist) || (distance <= bestDist && index < j))
                    {
                        // Update best one if better
                        closest = SectorsCopy[j];
                        index = j;
                    }
                }
                Result.Add(closest);
                Path += Math.Abs(head - closest);
                head = closest;
                SectorsCopy.RemoveAt(index);
            }
        }

        public void SCAN()
        {
            List<int> SectorsCopy = new List<int>(Sectors);
            List<int> FirstHalf = new List<int>();
            List<int> SecondHalf = new List<int>();

            // Add the initial head position for splitting the list
            // But do not add it to the final lists if it wasn't here before
            bool headAdded = false;
            if (!SectorsCopy.Contains(head))
            {
                SectorsCopy.Add(head);
                headAdded = true;
            }
            // Now sort the list and start splitting
            SectorsCopy.Sort();
            for (int i = 0; i < SectorsCopy.Count; i++)
            {
                // All positions before the initial head go into the lower first half
                if (SectorsCopy[i] < head) { FirstHalf.Add(SectorsCopy[i]); }
                else
                {
                    // All other positions go into the second half
                    // Do not include the head if it was added for splitting only
                    if (SectorsCopy[i] == head && headAdded) continue;
                    // Otherwise also include the head position (it will be first)
                    else SecondHalf.Add(SectorsCopy[i]);
                }
            }
            // Traverse the second half
            foreach (int pos in SecondHalf)
            {
                Result.Add(pos);
                Path += Math.Abs(head - pos);
                head = pos;
            }
            // Include the final point if it's not included already
            if (!SecondHalf.Contains(49))
            {
                Result.Add(49);
                Path += Math.Abs(head - 49);
                head = 49;
            }
            // Reverse the first half and traverse it (from R to L)
            FirstHalf.Reverse();
            foreach (int pos in FirstHalf)
            {
                Result.Add(pos);
                Path += Math.Abs(head - pos);
                head = pos;
            }
        }

        public void LOOK()
        {
            List<int> SectorsCopy = new List<int>(Sectors);
            List<int> FirstHalf = new List<int>();
            List<int> SecondHalf = new List<int>();

            // Add the initial head position for splitting the list
            // But do not add it to the final lists if it wasn't here before
            bool headAdded = false;
            if (!SectorsCopy.Contains(head))
            {
                SectorsCopy.Add(head);
                headAdded = true;
            }
            // Now sort the list and start splitting
            SectorsCopy.Sort();
            for (int i = 0; i < SectorsCopy.Count; i++)
            {
                // All positions before the initial head go into the lower first half
                if (SectorsCopy[i] < head) { FirstHalf.Add(SectorsCopy[i]); }
                else
                {
                    // All other positions go into the second half
                    // Do not include the head if it was added for splitting only
                    if (SectorsCopy[i] == head && headAdded) continue;
                    else SecondHalf.Add(SectorsCopy[i]);
                }
            }
            // Traverse the second half
            foreach (int pos in SecondHalf)
            {
                Result.Add(pos);
                Path += Math.Abs(head - pos);
                head = pos;
            }
            // Reverse the first half and traverse it (from R to L)
            FirstHalf.Reverse();
            foreach (int pos in FirstHalf)
            {
                Result.Add(pos);
                Path += Math.Abs(head - pos);
                head = pos;
            }
        }

        public void LoadFromString(string taskString)
        {
            String[] sektorid;
            try { sektorid = taskString.Trim().Split(','); }
            catch (FormatException) { throw; }
            // Must have at most 10 sector positions
            if (sektorid.Length > 10) throw new FormatException();

            foreach (string sektor in sektorid)
            {
                try
                {
                    // Try to parse or throw exception
                    int sektorInt = int.Parse(sektor);
                    // Incorrect length - must be [0, 50)
                    if (sektorInt > 49) throw new FormatException();
                    Sectors.Add(sektorInt);
                } catch (FormatException) { throw; }
            }
        }

        public void Clear()
        {
            this.Sectors.Clear();
            this.Result.Clear();
            this.Path = 0;
            this.head = 10;
        }
    }
}
