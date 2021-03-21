using System;
using System.Collections.Generic;
using System.Drawing;

namespace TeamManager.Entities
{
    public class FootballTactic
    {
        public List<Tactic> Tactics { get; set; }

        public FootballTactic()
        {
            Tactics = new List<Tactic>();

            Tactics.Add(new Tactic()
            {
                Name = "4-4-2",
                Positions = { "CF", "CF", "SM", "CM", "CM", "SM", "FB", "CB", "CB", "FB", "GK" },
                PositionsLocation =
                {
                    new Point(148, 62), new Point(315, 62),
                    new Point(35, 230), new Point(161, 265), new Point(300, 265), new Point(429, 230),
                    new Point(35, 425), new Point(161, 455), new Point(293, 455), new Point(429, 425),
                    new Point(232, 570)
                },
                PositionColors = {"Red", "Yellow", "Blue", "Green"},
            });

            Tactics.Add(new Tactic()
            {
                Name = "4-3-3",
                Positions = { "CF", "LW", "RW", "CM", "DM", "CM", "LB", "CB", "CB", "RB", "GK" },
                PositionsLocation =
                {
                    new Point(45, 62), new Point(235, 16), new Point(425, 62), 
                    new Point(142, 211), new Point(235, 300), new Point(320, 211), 
                    new Point(35, 450), new Point(162, 450), new Point(285, 450), new Point(411, 450),
                    new Point(232, 570)
                },
                PositionColors = { "Red", "Yellow", "Blue", "Green" },
            });

            Tactics.Add(new Tactic()
            {
                Name = "5-3-2",
                Positions = { "CF", "CF", "CM", "CM", "CM", "WB", "CB", "S", "CB", "WB", "GK" },
                PositionsLocation =
                {
                    new Point(148, 62), new Point(315, 62),
                    new Point(50, 260), new Point(235, 290), new Point(410, 260),
                    new Point(35, 390), new Point(127, 457), new Point(230, 475), new Point(328, 457), new Point(432, 390),
                    new Point(232, 570)
                },
                PositionColors = { "Red", "Yellow", "Blue", "Green" },
            });
        }

        public Tactic this [int index]
        {
            get
            {
                if (index >= Tactics.Count)
                    throw new IndexOutOfRangeException($"Index must be between [0-{Tactics.Count}");

                return Tactics[index];
            }
        }

        public int FindIndex(string tacticName)
        {
            var index = Tactics.FindIndex(t => t.Name == tacticName);

            if (index < 0)
                throw new IndexOutOfRangeException("Tactic could not find!");
            
            return index;
        }
    }
}