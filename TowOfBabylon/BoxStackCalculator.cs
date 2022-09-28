using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowOfBabylon.Models;

namespace TowOfBabylon
{
    public static class BoxStackCalculator
    {
        public static int CalculateMaxStackHeight(Box[] boxArray) => boxArray.RotateBoxes().SortBoxesByArea().GetMaxStackHeight(3 * boxArray.Length);

        private static Box[] RotateBoxes(this Box[] boxArray)
        {
            //Box Array to hold all combinations of dimensions
            var rotatedBoxes = new Box[boxArray.Length * 3];

            for (var i = 0; i < boxArray.Length; i++)
            {
                var box = boxArray[i];

                rotatedBoxes[3 * i] = new Box()
                {
                    Height = box.Height,
                    Width = Math.Max(box.Width, box.Depth),
                    Depth = Math.Min(box.Width, box.Depth)
                };

                rotatedBoxes[3 * i + 1] = new Box()
                {
                    Height = box.Width,
                    Width = Math.Max(box.Height, box.Depth),
                    Depth = Math.Min(box.Height, box.Depth)
                };

                rotatedBoxes[3 * i + 2] = new Box()
                {
                    Height = box.Depth,
                    Width = Math.Max(box.Width, box.Height),
                    Depth = Math.Min(box.Width, box.Height)
                };
            }

            return rotatedBoxes;
        }

        private static int GetMaxStackHeight(this Box[] rotatedBoxes, int count)
        {
            var maxStackHeight = new int[count];

            //Get Max Stack Height for each index
            for (var i = 0; i < count; i++)
                maxStackHeight[i] = rotatedBoxes[i].Height;

            //Calculate max stack heights based on each rotation
            for (var i = 0; i < count; i++)
            {
                maxStackHeight[i] = 0;

                var box = rotatedBoxes[i];
                var val = 0;

                for (var c = 0; c < i; c++)
                {
                    var previousBox = rotatedBoxes[c];
                    //Check to see if the current box rotation can stack on top of the previous
                    if (box.Width < previousBox.Width && box.Depth < previousBox.Depth)
                    {
                        val = Math.Max(val, maxStackHeight[c]);
                    }
                }
                maxStackHeight[i] = val + box.Height;
            }

            var max = -1;

            //Return the greatest possible stack height 
            for (var i = 0; i < count; i++)
            {
                max = Math.Max(max, maxStackHeight[i]);
            }

            return max;
        }

        private static Box[] SortBoxesByArea(this Box[] rotatedBoxes)
        {
            //Calculate and assign the Area of each box followed by a Sort based on Area
            for (var i = 0; i < rotatedBoxes.Length; i++)
                rotatedBoxes[i].Area = rotatedBoxes[i].Width * rotatedBoxes[i].Depth;

            Array.Sort(rotatedBoxes);

            return rotatedBoxes;
        }
    }
}
