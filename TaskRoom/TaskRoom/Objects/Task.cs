using System;
using System.Collections.Generic;
using System.Text;

namespace TaskRoom.Objects
{
    class Task
    {
        private string gameName;
        private int taskId;
        private int teacherId;
        private int classId;
        private string className;
        private string teacherName;
        private bool completed;
        private int time;

        public Task(string GameName, int TaskId, int TeachId, int ClassId, string ClassName, string TeacherName, int Time)
        {
            this.gameName = GameName;
            this.taskId = TaskId;
            this.teacherId = TeachId;
            this.classId = ClassId;
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
