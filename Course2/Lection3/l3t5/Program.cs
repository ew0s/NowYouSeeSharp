using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using l3t5.Interfaces;

namespace l3t5
{
    /*
     * Для интерфейса INotable добавьте следующие методы:
     *      1) CreateNote, который возвращает новый экземпляр класса Note и принимает последовательно
     *         все параметры, необходимые для его создания.
     *      2) UpdateNote, который ничего не возвращает, а принимает экземпляр класса Note и обновляет
     *         его значения путём установки всем его полям значений по умолчанию.
     *      3) ReadNote, который принимает экземпляр класса Note, а возвращает строковое представление 
     *         экземпляра класса Note в следующем формате "ID == XXX, BODY == XXX, DATE == XXX, ALERT == XXX", 
     *         где ХХХ - соответствующие значения переданного экземпляра класса. При этом дата должна
     *         выводиться в формате: "день(2 цифры) месяц(на английском языке) год(4 цифры)".
     *      4) DeleteNote, принимает список элементов класса Note и значение Id экземпляра класса Note,
     *         подлежащего удалению. Метод должен возвращать значение true в случае если экземпляр с указанным 
     *         Id существует в списке и false в противном случае.
     * Внутри класса MobilePhone реализуйте интерфейс INotable в соответствии с указанной логикой описания
     * методов интерфейса, а также добавьте публичный статический список экземпляров класса Note инициализировав
     * его пустым списком соответствующих экземпляров класса.
     * Шаблон класса Note изменять нельзя.
     */

    public class MobilePhone : INotable
    {
        public static List<Note> List = new List<Note>();
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }

        public Note CreateNote(int id, string body, DateTime date, bool isAlertNeeded)
        {
            return new Note(id, body, date, isAlertNeeded);
        }

        public void UpdateNote(Note note)
        {
            note.Body = default;
            note.Date = default;
            note.Id = default;
            note.IsAlertNeeded = default;
        }

        public string ReadNote(Note note)
        {
            return $"ID == {note.Id}, BODY == {note.Body}, DATE == {note.Date.ToString("dd MMMM yyyy", new CultureInfo("en-En"))}, ALERT == {note.IsAlertNeeded}";
        }

        public bool DeleteNote(List<Note> list, int id)
        {
            foreach (var note in list)
            {
                if (note.Id == id)
                {
                    list.Remove(note);
                    return true;
                }
            }

            return false;
        }
    }
}
