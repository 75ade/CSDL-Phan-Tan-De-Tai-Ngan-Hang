using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectNHPT.DTO
{
    public class UserEventData
    {
        public enum EventType
        {
            CANCEL_EDIT,
            INSERT,
            DELETE,
            UPDATE
        }

        private EventType type;
        private object content;
        private int gridPos;

        //Constructor:
        public UserEventData()
        {

        }

        public UserEventData(EventType type, object content, int gridPos)
        {
            this.type = type;
            this.content = content;
            this.gridPos = gridPos;
        }

        //Getter and setter:
        public EventType Type { get => type; set => type = value; }
        public object Content { get => content; set => content = value; }
        public int GridPos { get => gridPos; set => gridPos = value; }


    }
}
