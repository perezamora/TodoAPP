using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Common.Logic.Model
{
    public class Tarea
    {
        #region Attributes
        [Key]
        [Column(Order=0)]
        public int Id { get; set; }
        public string Guid { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateFinal { get; set; }
        public DateTime DateUpdate { get; set; }
        #endregion

        #region Metodos
        public Tarea() { }

        /*
        public Tarea(int id, string guid, string title, string comment, DateTime dateCreate, DateTime dateFinal, DateTime dateUpdate)
        {
            this.Id = id;
            this.guid = guid;
            this.Title = title;
            this.Comment = comment;
            this.dateCreate = dateCreate;
            this.dateFinal = dateFinal;
            this.dateUpdate = dateUpdate;
        }*/
        #endregion

        #region Propiedades
        /*
        public int Id { get => id; set => id = value; }
        public string Guid { get => guid; set => guid = value; }
        public string Title { get => title; set => title = value; }
        public string Comment { get => comment; set => comment = value; }
        public DateTime DateCreate { get => dateCreate; set => dateCreate = value; }
        public DateTime DateFinal { get => dateFinal; set => dateFinal = value; }
        public DateTime DateUpdate { get => dateUpdate; set => dateUpdate = value; }*/

        public override String ToString() => string.Format("{0};{1};{2};{3};{4};{5};{6};",
               this.Id, this.Guid, this.Title, this.Comment, this.DateCreate, this.DateFinal, this.DateUpdate);
        /*
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
        }*/
        #endregion

    }
}
