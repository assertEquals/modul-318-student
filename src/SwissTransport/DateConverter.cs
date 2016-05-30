﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransport
{
    public class DateConverter {

        public DateConverter() {

        }

        public String getDateFromDateTime(DateTime dateTime) {
            String date = "";
            date = dateTime.Year.ToString();
            date = date + "-" + dateTime.Month.ToString();
            date = date + "-" + dateTime.Day.ToString();
            return date;
        }

        public DateTime getDurationFromDurationString(String dateTimeString) {
            String yearString = dateTimeString.Substring(0, 4);
            String monthString = dateTimeString.Substring(5, 2);
            String dayString = dateTimeString.Substring(8, 2);
            String hoursString = dateTimeString.Substring(11, 2);
            String minutesString = dateTimeString.Substring(14, 2);
            int year = Convert.ToInt32(yearString);
            int month = Convert.ToInt32(monthString);
            int day = Convert.ToInt32(dayString);
            int hours = Convert.ToInt32(hoursString);
            int minutes = Convert.ToInt32(minutesString);
            DateTime dateTime = new DateTime();
            dateTime = dateTime.AddYears(year - 1);
            dateTime = dateTime.AddMonths(month - 1);
            dateTime = dateTime.AddDays(day - 1);
            dateTime = dateTime.AddHours(hours - 1);
            dateTime = dateTime.AddMinutes(minutes);
            return dateTime;
        }

        public String convertIntToTimeString(int time) {
            String timeString = time.ToString();
            if (time < 10) {
                timeString = "0" + time;
            }
            return timeString;
        }

        public String getTimeFromDateTime(DateTime dt) {
            String time;
            if (dt.Hour < 10 && dt.Minute < 10) {
                time = "0" + dt.Hour.ToString() + ":0" + dt.Minute.ToString();
                return time;
            }
            if (dt.Hour < 10 && dt.Minute > 10) {
                time = "0" + dt.Hour.ToString() + ":" + dt.Minute.ToString();
                return time;
            }
            if (dt.Hour > 10 && dt.Minute < 10) {
                time = dt.Hour.ToString() + ":0" + dt.Minute.ToString();
                return time;
            }
            time = dt.Hour.ToString() + ":" + dt.Minute.ToString();
            return time;
            }
       }
 }