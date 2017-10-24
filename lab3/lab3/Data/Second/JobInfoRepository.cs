using System;
using System.Collections.Generic;
using System.Text;

namespace lab3.Data._2
{
    class JobInfoRepository
    {
        public List<JobInfo> jobsInfo { get; set; }

        public JobInfoRepository()
        {
            jobsInfo.Add(new JobInfo("Scala", 0, "passionate", 1000));
            jobsInfo.Add(new JobInfo("Scala", 1, "Akka", 2000));
            jobsInfo.Add(new JobInfo("Scala", 2, "FP", 3000));
            jobsInfo.Add(new JobInfo("Scala", 3, "BigData", 4000));
        }

        public List<JobInfo> GetJobByTitle(string jobTitle)
        {
            return jobsInfo.FindAll(j => j.Title == jobTitle);
        }

        public List<JobInfo> FindAllJobs()
        {
            return jobsInfo;
        }

        public void AddJob(JobInfo jobInfo)
        {
            jobsInfo.Add(jobInfo);
        }

        public List<JobInfo> GetJobByPosition(int position)
        {
            return jobsInfo.FindAll(e => e.MinimumYearsOfExperience == position);
        }

        public void RemoveJobsWithTitle(string jobTitle)
        {
            jobsInfo.RemoveAll(e => e.Title == jobTitle);
        }

        public List<JobInfo> GetJobsWithSalaryHigherThan(int limit)
        {
            return jobsInfo.FindAll(e => e.Salary > limit);
        }
    }
}
