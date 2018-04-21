using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Common.Logic.Model
{
    public class Tarea
    {
        #region Attributes
        private int id;
        private string guid;
        private string title;
        private string comment;
        private DateTime dateCreate;
        private DateTime dateFinal;
        private DateTime dateUpdate;
        #endregion

        #region Metodos
        public Tarea() { }

        public Tarea(int id, string guid, string title, string comment, DateTime dateCreate, DateTime dateFinal, DateTime dateUpdate)
        {
            this.Id = id;
            this.guid = guid;
            this.Title = title;
            this.Comment = comment;
            this.dateCreate = dateCreate;
            this.dateFinal = dateFinal;
            this.dateUpdate = dateUpdate;
        }
        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Guid { get => guid; set => guid = value; }
        public string Title { get => title; set => title = value; }
        public string Comment { get => comment; set => comment = value; }
        public DateTime DateCreate { get => dateCreate; set => dateCreate = value; }
        public DateTime DateFinal { get => dateFinal; set => dateFinal = value; }
        public DateTime DateUpdate { get => dateUpdate; set => dateUpdate = value; }

        public override String ToString() => string.Format("{0};{1};{2};{3};{4};{5};{6};",
               this.id, this.guid, this.title, this.comment, this.dateCreate, this.dateFinal, this.dateUpdate);

        public override bool Equals(object obj)
        {
            var task = obj as Tarea;
            return task != null &&
                   id == task.id &&
                   guid == task.guid &&
                   title == task.title &&
                   comment == task.comment &&
                   dateCreate == task.dateCreate &&
                   dateFinal == task.dateFinal &&
                   dateUpdate == task.dateUpdate &&
                   Id == task.Id &&
                   Guid == task.Guid &&
                   Title == task.Title &&
                   Comment == task.Comment &&
                   DateCreate == task.DateCreate &&
                   DateFinal == task.DateFinal &&
                   DateUpdate == task.DateUpdate;
        }

        public override int GetHashCode()
        {
            var hashCode = 2035429558;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(title);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(comment);
            hashCode = hashCode * -1521134295 + dateCreate.GetHashCode();
            hashCode = hashCode * -1521134295 + dateFinal.GetHashCode();
            hashCode = hashCode * -1521134295 + dateUpdate.GetHashCode();
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Guid);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Comment);
            hashCode = hashCode * -1521134295 + DateCreate.GetHashCode();
            hashCode = hashCode * -1521134295 + DateFinal.GetHashCode();
            hashCode = hashCode * -1521134295 + DateUpdate.GetHashCode();
            return hashCode;
        }
        #endregion

    }
}
