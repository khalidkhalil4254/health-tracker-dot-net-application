using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_programming_assignment
{
    public class userDataModel
    {

        int detailsId;
        double steps;
        double weight;
        double height;
        double age;
        double burned_cal;
        string exerciseDate;

        public userDataModel(int detailsId,double steps,double wei,double hei,double age,double burned_cal,string exercise_date) {
            this.detailsId = detailsId;       
            this.steps = steps;
            this.weight = wei;
            this.height = hei;
            this.age = age;
            this.burned_cal = burned_cal;
            this.exerciseDate = exercise_date;
        }


    }
}
