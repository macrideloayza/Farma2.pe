﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI_Farma.pe.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BD_FARMACIAEntities : DbContext
    {
        public BD_FARMACIAEntities()
            : base("name=BD_FARMACIAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADVERTENCIA> ADVERTENCIAs { get; set; }
        public virtual DbSet<DISTRITO> DISTRITOes { get; set; }
        public virtual DbSet<FARMACIA> FARMACIAs { get; set; }
        public virtual DbSet<FAVORITO> FAVORITOes { get; set; }
        public virtual DbSet<FORMA_USO> FORMA_USO { get; set; }
        public virtual DbSet<LABORATORIO> LABORATORIOs { get; set; }
        public virtual DbSet<MEDICAMENTO> MEDICAMENTOes { get; set; }
        public virtual DbSet<MEDICAMENTO_FARMACIA> MEDICAMENTO_FARMACIA { get; set; }
        public virtual DbSet<PERSONA> PERSONAs { get; set; }
        public virtual DbSet<PRESENTACION> PRESENTACIONs { get; set; }
        public virtual DbSet<PROMOCION> PROMOCIONs { get; set; }
        public virtual DbSet<SINTOMA> SINTOMAs { get; set; }
        public virtual DbSet<USUARIO> USUARIOs { get; set; }
    
        public virtual ObjectResult<USP_FARMACIA_X_DISTRITO_Result> USP_FARMACIA_X_DISTRITO(Nullable<int> iD_DIS)
        {
            var iD_DISParameter = iD_DIS.HasValue ?
                new ObjectParameter("ID_DIS", iD_DIS) :
                new ObjectParameter("ID_DIS", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_FARMACIA_X_DISTRITO_Result>("USP_FARMACIA_X_DISTRITO", iD_DISParameter);
        }
    
        public virtual ObjectResult<USP_MEDICAMENTO_FILTRO_Result> USP_MEDICAMENTO_FILTRO(Nullable<int> iD_ADV, Nullable<int> iD_FOR, Nullable<int> iD_PRE, Nullable<int> iD_SIN)
        {
            var iD_ADVParameter = iD_ADV.HasValue ?
                new ObjectParameter("ID_ADV", iD_ADV) :
                new ObjectParameter("ID_ADV", typeof(int));
    
            var iD_FORParameter = iD_FOR.HasValue ?
                new ObjectParameter("ID_FOR", iD_FOR) :
                new ObjectParameter("ID_FOR", typeof(int));
    
            var iD_PREParameter = iD_PRE.HasValue ?
                new ObjectParameter("ID_PRE", iD_PRE) :
                new ObjectParameter("ID_PRE", typeof(int));
    
            var iD_SINParameter = iD_SIN.HasValue ?
                new ObjectParameter("ID_SIN", iD_SIN) :
                new ObjectParameter("ID_SIN", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_MEDICAMENTO_FILTRO_Result>("USP_MEDICAMENTO_FILTRO", iD_ADVParameter, iD_FORParameter, iD_PREParameter, iD_SINParameter);
        }
    
        public virtual ObjectResult<USP_VALIDAR_USUARIO_Result> USP_VALIDAR_USUARIO(string nOM_USU, string pASS_USU)
        {
            var nOM_USUParameter = nOM_USU != null ?
                new ObjectParameter("NOM_USU", nOM_USU) :
                new ObjectParameter("NOM_USU", typeof(string));
    
            var pASS_USUParameter = pASS_USU != null ?
                new ObjectParameter("PASS_USU", pASS_USU) :
                new ObjectParameter("PASS_USU", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_VALIDAR_USUARIO_Result>("USP_VALIDAR_USUARIO", nOM_USUParameter, pASS_USUParameter);
        }
    }
}
