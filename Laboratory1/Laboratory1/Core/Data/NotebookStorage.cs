using System;
using System.Collections.Generic;
using System.Linq;

namespace Laboratory1.Core.DATA
{
    public class NotebookStorage
    {
        private readonly Dictionary<uint, Record> _notebookRecords;

        public NotebookStorage()
        {
            _notebookRecords = new Dictionary<uint, Record>();
        }

        public bool TryWriteRecord(uint id, Record record)
        {
            if (_notebookRecords.ContainsKey(id))
            {
                return false;
            }
            
            _notebookRecords.Add(id, record);
            return true;
        }
        
        // Этот метод призван обеспечивать редактирование записей в записной книжке
        public bool TryGetRecord(uint id, out Record recordToEdit)
        {
            if (_notebookRecords.ContainsKey(id))
            {
                recordToEdit = _notebookRecords[id];
                return true;
            }

            recordToEdit = null;
            return false;
        }

        public bool TryDeleteRecord(uint id)
        {
            if (!_notebookRecords.ContainsKey(id)) return false;
            _notebookRecords.Remove(id);
            return true;
        }

        public IEnumerable<Record> GetEnumerator()
        {
            return _notebookRecords.Select(records => records.Value);
        }

        public bool TryGetStringRecord(uint id, out string stringRecord)
        {
            if (_notebookRecords.ContainsKey(id))
            {
                stringRecord = _notebookRecords[id].ToString();
                return true;
            }

            stringRecord = null;
            return false;
        }

        public void ShowAllRecords()
        {
            foreach (KeyValuePair<uint,Record> notebookRecord in _notebookRecords)
            {
                Console.WriteLine(notebookRecord.Value.ToString());
            }
        }
    }
}