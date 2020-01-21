using System;
using System.Collections.Generic;
using System.Text;

namespace TaskRoom.Objects
{
    class Task
    {
        string gameName;
        int taskId;
        int teacherId;
        int classId;
        string className;
        string teacherName;
        bool completed;
        int time;

        public Task(string GameName, int TaskId, int TeachId, int ClassId, string ClassName, string TeacherName, int Time)
        {
            this.gameName = GameName;
            this.taskId = TaskId;
            this.teacherId = TeachId;
            this.classId = CslassId;
            this.className = ClassName;
            this.teacherName = TeacherName;
            this.completed = false;
            this.time = Time;
        }

        void TaskFinished()
        {
            this.completed = true;
        }

    }
}
