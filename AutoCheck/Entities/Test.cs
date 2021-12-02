using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCheck.Entities
{
    internal class Test
    {
        public int ID { get; set; }
        public List<Question> Questions { get; set; }

        public Test()
        {
            this.Questions = new List<Question>();
        }

        public void Random()
        {
            Random random = new Random();
            List<int> lstIndex = new List<int>();
            for (int i = 0; i < this.Questions.Count; i++)
            {
                int index;
                do
                {
                    index = random.Next(0, this.Questions.Count);
                } while (lstIndex.IndexOf(index) != -1);
                lstIndex.Add(index);
            }

            List<Question> tempQuestions = new List<Question>();
            foreach(Question question in this.Questions)
            {
                tempQuestions.Add(question);
            }

            for(int i = 0; i < this.Questions.Count; i++)
            {
                this.Questions[i] = tempQuestions[lstIndex[i]];
                this.Questions[i].Random();
            }
        }
    }
}
