/* Title:           Project Productivity Reports Class
 * Date:            1-15-19
 * Author:          Terry Holmes
 * 
 * Description:     This class is for project productivity reports */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace ProjectProductivityReportsDLL
{
    public class ProjectProductivityReportsClass
    {
        //setting up the classes
        EventLogClass TheEventLogClass = new EventLogClass();

        FindProjectProductivityByDateRangeDataSet aFindProjectProductivityByDateRangeDataSet;
        FindProjectProductivityByDateRangeDataSetTableAdapters.FindProjectProductivityTotalsByDateRangeTableAdapter aFindProjectProductivityByDateRangeTableAdapter;

        FindDesignProjectProductivityByDateRangeDataSet aFindDesignProjectProductivityByDateRangeDataSet;
        FindDesignProjectProductivityByDateRangeDataSetTableAdapters.FindDesignProjectProductivityByDateRangeTableAdapter aFindDesignProjectProductivityByDateRangeTableAdapter;

        FindPrivateProjectProductivityDateRangeDataSet aFindPrivateProjectProductivityDateRangeDataSet;
        FindPrivateProjectProductivityDateRangeDataSetTableAdapters.FindPrivateProjectProductivityDateRangeTableAdapter aFindPrivateProjectProductivityDateRangeTableAdapter;

        FindDesignPrivateProjectProductivityDateRangeDataSet aFindDesignPrivateProjectProductivityDateRangeDataSet;
        FindDesignPrivateProjectProductivityDateRangeDataSetTableAdapters.FindDesignPrivateProjectProductivityDateRangeTableAdapter aFindDesignPrivateProjectProductivityDateRangeTableAdapter;

        public FindDesignPrivateProjectProductivityDateRangeDataSet FindDesignPrivateProjectProductivityDateRange(string strFirstProject, string strSecondProject, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindDesignPrivateProjectProductivityDateRangeDataSet = new FindDesignPrivateProjectProductivityDateRangeDataSet();
                aFindDesignPrivateProjectProductivityDateRangeTableAdapter = new FindDesignPrivateProjectProductivityDateRangeDataSetTableAdapters.FindDesignPrivateProjectProductivityDateRangeTableAdapter();
                aFindDesignPrivateProjectProductivityDateRangeTableAdapter.Fill(aFindDesignPrivateProjectProductivityDateRangeDataSet.FindDesignPrivateProjectProductivityDateRange, strFirstProject, strSecondProject, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Productivity Reports Class // Find Design Private Project Productivity Date Range " + Ex.Message);
            }

            return aFindDesignPrivateProjectProductivityDateRangeDataSet;
        }
        public FindPrivateProjectProductivityDateRangeDataSet FindPrivateProjectProductivityDateRange(string strFirstProject, string strSecondProject, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindPrivateProjectProductivityDateRangeDataSet = new FindPrivateProjectProductivityDateRangeDataSet();
                aFindPrivateProjectProductivityDateRangeTableAdapter = new FindPrivateProjectProductivityDateRangeDataSetTableAdapters.FindPrivateProjectProductivityDateRangeTableAdapter();
                aFindPrivateProjectProductivityDateRangeTableAdapter.Fill(aFindPrivateProjectProductivityDateRangeDataSet.FindPrivateProjectProductivityDateRange, strFirstProject, strSecondProject, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Productivity Reports Class // Find Private Project Productivity Date Range " + Ex.Message);
            }

            return aFindPrivateProjectProductivityDateRangeDataSet;
        }
        public FindDesignProjectProductivityByDateRangeDataSet FindDesignProjectProductivityByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindDesignProjectProductivityByDateRangeDataSet = new FindDesignProjectProductivityByDateRangeDataSet();
                aFindDesignProjectProductivityByDateRangeTableAdapter = new FindDesignProjectProductivityByDateRangeDataSetTableAdapters.FindDesignProjectProductivityByDateRangeTableAdapter();
                aFindDesignProjectProductivityByDateRangeTableAdapter.Fill(aFindDesignProjectProductivityByDateRangeDataSet.FindDesignProjectProductivityByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Productivity Reports Class // Find Design Project Productivity By Date Range " + Ex.Message);
            }

            return aFindDesignProjectProductivityByDateRangeDataSet;
        }
        public FindProjectProductivityByDateRangeDataSet FindProjectProductivityByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindProjectProductivityByDateRangeDataSet = new FindProjectProductivityByDateRangeDataSet();
                aFindProjectProductivityByDateRangeTableAdapter = new FindProjectProductivityByDateRangeDataSetTableAdapters.FindProjectProductivityTotalsByDateRangeTableAdapter();
                aFindProjectProductivityByDateRangeTableAdapter.Fill(aFindProjectProductivityByDateRangeDataSet.FindProjectProductivityTotalsByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Productivity Reports Class // Find Project Productivity By Date Range " + Ex.Message);
            }

            return aFindProjectProductivityByDateRangeDataSet;
        }
    }
}
