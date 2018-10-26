using System;

namespace WindowsFormsApp3
{
    internal class Number1
    {

        private DateTime start;
        private DateTime finish;
        private Boolean vac;
        private TimeSpan days;

        public Number1()
        {
        }

        public  void setStart(DateTime value)
        {
            this.start = value;

        }
        public void setFinish(DateTime value)
        {
            this.finish = value;
        }
        public DateTime getStart()
        {
            return this.start;
        }
        public DateTime getFinish()
        {
            return this.finish;
        }
        public void setVac(bool v)
        {
            this.vac = v;
        } 
        public Boolean getVac()
        {
            return this.vac;
        }
        public void setDays(TimeSpan j)
        {
            this.days = j;
        }
        public TimeSpan getDays()
        {
            return this.days;
        }

    }
}