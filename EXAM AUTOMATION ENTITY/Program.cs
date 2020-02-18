using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace examautomation
{
      public class Program
        {
        static ExaminationSystemEntities1 ese = new ExaminationSystemEntities1();
            static void Main(string[] args)
            {
                Show();
                GetResults();
                Console.Read();
            }

            public static void Show()
            {

                var std = ese.Students;

                foreach (var s in std)
                {
                    Console.WriteLine("Seat No: {0}\nStudent Name: {1}\nExam Code: {2}\nExam Name: {3}\nExam Date: {4}\nDuration: {5}\nCenter Code: {6}\nCenter Name: {7}\nAddress: {8}",
                        s.seat_number,
                        s.student_name,
                        s.exam_code,
                        s.ExamDetail.exam_name,
                        s.ExamDetail.exam_date,
                        s.ExamDetail.time_duration,
                        s.center_code,
                        s.Center.center_name,
                        s.Center.center_address);

                    Console.WriteLine("\n\n-------------------------------------------------------------------------------------------\n");
                }
            }

            public static void GetResults()
            {
                var results = ese.Results;

                foreach (var r in results)
                {
                    Console.WriteLine("Seat No: {0}\nMarks Obtained: {1}\nTotal Marks: {2}\nPercentage: {3}\nResult: {4}",
                       r.seat_number,
                       r.marks_obtained,
                       r.total_marks,
                       r.percentage,
                       r.result1);

                    Console.WriteLine("\n\n-------------------------------------------------------------------------------\n");
                }
            }
        }
    }
