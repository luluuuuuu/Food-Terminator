using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Ninja
{
    public class Settings
    {
        public int width;
        public int height;
        public string difficulty;

        public Settings(int width, int height, string difficulty)
        {
            this.width = width;
            this.height = height;
            this.difficulty = difficulty;
        }
    }
}
