using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Microsoft.Reporting.WebForms;

using Coomuce.GestorReportes.Entidad;
using Coomuce.GestorReportes.Modelo;
using System.Xml.Serialization;

namespace Coomuce.GestorReportes
{
    public partial class Lanzador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportDataSource dataSource = null;

            this.ReportViewer1.LocalReport.DataSources.Clear();
            this.ReportViewer1.LocalReport.EnableExternalImages = true;
            this.ReportViewer1.LocalReport.EnableHyperlinks = true;

            byte idReporte = byte.Parse(Request.Params.Get("idReporte"));
            string condicion = Request.Params.Get("condicion");

            string sql = "";
            string fechaInicio = "";
            string fechaFin = "";
            string idCiudad = "";
            string documento = "";
            string fechaFicha = "";

            var db = new CoomuceEntities();
            db.Database.CommandTimeout = 300;
            switch (idReporte)
            {
                case 1:
                    sql = @"SELECT idCondicionDiscapacidad, codigoCondicionDiscapacidad, nombreCondicionDiscapacidad
                            FROM PAR.CondicionDiscapacidad" + (string.IsNullOrEmpty(condicion) ? "" : " where " + condicion);

                    var datos1 = db.Database.SqlQuery<CondicionDiscapacidad>(sql).ToList();

                    dataSource = new ReportDataSource("DataSet1", datos1);

                    this.ReportViewer1.LocalReport.ReportPath = "Reportes/CondicionDiscapacidad.rdlc";
                    this.ReportViewer1.LocalReport.DataSources.Add(dataSource);

                    break;
                case 2:
                    sql = @"SELECT idDeclaracionAutorizacion, codigoDeclaracionAutorizacion, descripcionDeclaracionAutorizacion
                            FROM PAR.DeclaracionAutorizacion" + (string.IsNullOrEmpty(condicion) ? "" : " where " + condicion);

                    var datos2 = db.Database.SqlQuery<DeclaracionAutorizacion>(sql).ToList();

                    dataSource = new ReportDataSource("DataSet1", datos2);

                    this.ReportViewer1.LocalReport.ReportPath = "Reportes/DeclaracionAutorizacion.rdlc";
                    this.ReportViewer1.LocalReport.DataSources.Add(dataSource);

                    break;
                case 3:
                    sql = @"SELECT idGrupoPoblacional, codigoGrupoPoblacional, nombreGrupoPoblacional
                            FROM PAR.GrupoPoblacional" + (string.IsNullOrEmpty(condicion) ? "" : " where " + condicion);

                    var datos3 = db.Database.SqlQuery<GrupoPoblacional>(sql).ToList();

                    dataSource = new ReportDataSource("DataSet1", datos3);

                    this.ReportViewer1.LocalReport.ReportPath = "Reportes/GrupoPoblacional.rdlc";
                    this.ReportViewer1.LocalReport.DataSources.Add(dataSource);

                    break;
                case 4:
                    sql = @"SELECT idMotivoTraslado, codigoMotivoTraslado, descripcionMotivoTraslado
                            FROM PAR.MotivoTraslado" + (string.IsNullOrEmpty(condicion) ? "" : " where " + condicion);

                    var datos4 = db.Database.SqlQuery<MotivoTraslado>(sql).ToList();

                    dataSource = new ReportDataSource("DataSet1", datos4);

                    this.ReportViewer1.LocalReport.ReportPath = "Reportes/MotivoTraslado.rdlc";
                    this.ReportViewer1.LocalReport.DataSources.Add(dataSource);

                    break;
                case 5:
                    sql = @"SELECT idCicloVital, edadMinCicloVital, edadMaxCicloVital
                            FROM PAR.CicloVital" + (string.IsNullOrEmpty(condicion) ? "" : " where " + condicion);

                    var datos5 = db.Database.SqlQuery<CicloVital>(sql).ToList();

                    dataSource = new ReportDataSource("DataSet1", datos5);

                    this.ReportViewer1.LocalReport.ReportPath = "Reportes/CicloVital.rdlc";
                    this.ReportViewer1.LocalReport.DataSources.Add(dataSource);

                    break;
                case 6:
                    sql = @"SELECT idCondicionVivienda, nombreCondicionVivienda
                            FROM PAR.CondicionVivienda" + (string.IsNullOrEmpty(condicion) ? "" : " where " + condicion);

                    var datos6 = db.Database.SqlQuery<CondicionVivienda>(sql).ToList();

                    dataSource = new ReportDataSource("DataSet1", datos6);

                    this.ReportViewer1.LocalReport.ReportPath = "Reportes/CondicionesVivienda.rdlc";
                    this.ReportViewer1.LocalReport.DataSources.Add(dataSource);

                    break;
                case 7:
                    sql = @"SELECT	a.idFactorRiesgo, codigoFactorRiesgo, nombreFactorRiesgo, codigoSubFactorRiesgo, nombreSubFactorRiesgo
                            FROM PAR.FactorRiesgo as a 
	                            left join PAR.SubFactorRiesgo as b on a.idFactorRiesgo = b.idFactorRiesgo" + (string.IsNullOrEmpty(condicion) ? "" : " where " + condicion);

                    var datos7 = db.Database.SqlQuery<FactorSubFactorRiesgo>(sql).ToList();

                    dataSource = new ReportDataSource("DataSet1", datos7);

                    this.ReportViewer1.LocalReport.ReportPath = "Reportes/FactorSubFactorRiesgo.rdlc";
                    this.ReportViewer1.LocalReport.DataSources.Add(dataSource);

                    break;
                case 8:
                    sql = @"SELECT idGrupoInteres, codigoGrupoInteres, descripcionGrupoInteres
                            FROM PAR.GrupoInteres" + (string.IsNullOrEmpty(condicion) ? "" : " where " + condicion);

                    var datos8 = db.Database.SqlQuery<GrupoInteres>(sql).ToList();

                    dataSource = new ReportDataSource("DataSet1", datos8);

                    this.ReportViewer1.LocalReport.ReportPath = "Reportes/GrupoInteres.rdlc";
                    this.ReportViewer1.LocalReport.DataSources.Add(dataSource);

                    break;
                case 9:
                    sql = @"SELECT idMotivoConsulta, codigoMotivoConsulta, descripcionMotivoConsulta
                            FROM PAR.MotivoConsulta" + (string.IsNullOrEmpty(condicion) ? "" : " where " + condicion);

                    var datos9 = db.Database.SqlQuery<MotivoConsulta>(sql).ToList();

                    dataSource = new ReportDataSource("DataSet1", datos9);

                    this.ReportViewer1.LocalReport.ReportPath = "Reportes/MotivoConsulta.rdlc";
                    this.ReportViewer1.LocalReport.DataSources.Add(dataSource);

                    break;
                case 10:
                    sql = @"SELECT idMotivoContacto, codigoMotivoContacto, descripcionMotivoContacto
                            FROM PAR.MotivoContacto" + (string.IsNullOrEmpty(condicion) ? "" : " where " + condicion);

                    var datos10 = db.Database.SqlQuery<MotivoContacto>(sql).ToList();

                    dataSource = new ReportDataSource("DataSet1", datos10);

                    this.ReportViewer1.LocalReport.ReportPath = "Reportes/MotivoContacto.rdlc";
                    this.ReportViewer1.LocalReport.DataSources.Add(dataSource);

                    break;
                case 11:
                    sql = @"SELECT idPiezasInformativas, codigoPiezasInformativas, descripcionPiezasInformativas
                            FROM PAR.PiezasInformativas" + (string.IsNullOrEmpty(condicion) ? "" : " where " + condicion);

                    var datos11 = db.Database.SqlQuery<PiezasInformativas>(sql).ToList();

                    dataSource = new ReportDataSource("DataSet1", datos11);

                    this.ReportViewer1.LocalReport.ReportPath = "Reportes/PiezasInformativas.rdlc";
                    this.ReportViewer1.LocalReport.DataSources.Add(dataSource);

                    break;
                case 12:
                    sql = @"SELECT idProgramaResolucion412, codigoProgramaResolucion412, descripcionProgramaResolucion412
                            FROM PAR.ProgramaResolucion412" + (string.IsNullOrEmpty(condicion) ? "" : " where " + condicion);

                    var datos12 = db.Database.SqlQuery<ProgramaResolucion412>(sql).ToList();

                    dataSource = new ReportDataSource("DataSet1", datos12);

                    this.ReportViewer1.LocalReport.ReportPath = "Reportes/ProgramaResolucion412.rdlc";
                    this.ReportViewer1.LocalReport.DataSources.Add(dataSource);

                    break;
                case 13:
                    sql = @"SELECT idSeguimientoProgramasIntervencionRiesgo, codigoSeguimientoProgramasIntervencionRiesgo, nombreSeguimientoProgramasIntervencionRiesgo
                            FROM PAR.SeguimientoProgramasIntervencionRiesgo" + (string.IsNullOrEmpty(condicion) ? "" : " where " + condicion);

                    var datos13 = db.Database.SqlQuery<SeguimientoProgramasIntervencionRiesgo>(sql).ToList();

                    dataSource = new ReportDataSource("DataSet1", datos13);

                    this.ReportViewer1.LocalReport.ReportPath = "Reportes/SeguimientoProgramasIntervencionRiesgo.rdlc";
                    this.ReportViewer1.LocalReport.DataSources.Add(dataSource);

                    break;
                case 14:
                    sql = @"SELECT idGruposFocales, codigoGruposFocales, nombreGruposFocales
                            FROM PAR.GruposFocales" + (string.IsNullOrEmpty(condicion) ? "" : " where " + condicion);

                    var datos14 = db.Database.SqlQuery<GruposFocales>(sql).ToList();

                    dataSource = new ReportDataSource("DataSet1", datos14);

                    this.ReportViewer1.LocalReport.ReportPath = "Reportes/GruposFocales.rdlc";
                    this.ReportViewer1.LocalReport.DataSources.Add(dataSource);

                    break;
                case 15:
                    sql = @"SELECT idIps, codigoIps, razonIps, b.codigoTipoIdentificacion, identificacionIps, direccionIps, 
	                            telefonoIps, d.nombreDepartamento, c.nombreCiudad, representanteIps, nivelIps, contactoIps, emailIps
                            FROM PAR.Ips as a 
	                            left join PAR.TipoIdentificacion as b on a.idTipoIdentificacion = b.idTipoIdentificacion 
	                            left join ADM.Ciudad as c on a.idCiudad = c.idCiudad 
	                            left join ADM.Departamento as d on c.idDepartamento = d.idDepartamento" + (string.IsNullOrEmpty(condicion) ? "" : " where " + condicion);

                    var datos15 = db.Database.SqlQuery<IpsModel>(sql).ToList();

                    dataSource = new ReportDataSource("DataSet1", datos15);

                    this.ReportViewer1.LocalReport.ReportPath = "Reportes/Ips.rdlc";
                    this.ReportViewer1.LocalReport.DataSources.Add(dataSource);

                    break;
                case 16:
                    sql = @"SELECT a.idEje, codigoEje, nombreEje, codigoUnidad, nombreUnidad, codigoModulo, nombreModulo
                            FROM PAR.Eje as a 
	                            left join PAR.Unidad as b on a.idEje = b.idEje 
	                            left join PAR.Modulo as c on b.idUnidad = c.idUnidad" + (string.IsNullOrEmpty(condicion) ? "" : " where " + condicion);

                    var datos16 = db.Database.SqlQuery<EjeUnidadModulo>(sql).ToList();

                    dataSource = new ReportDataSource("DataSet1", datos16);

                    this.ReportViewer1.LocalReport.ReportPath = "Reportes/EjeUnidadModulo.rdlc";
                    this.ReportViewer1.LocalReport.DataSources.Add(dataSource);

                    break;
                case 17:
                    var nombreTabla = Request.Params.Get("nombreTabla");
                    nombreTabla = nombreTabla == "null" ? "" : nombreTabla;
                    fechaInicio = Request.Params.Get("fechaInicio");
                    fechaFin = Request.Params.Get("fechaFin");
                    var idUsuario = Request.Params.Get("idUsuario");
                    idUsuario = idUsuario == "null" ? "0" : idUsuario;
                    idCiudad = Request.Params.Get("idCiudad");
                    idCiudad = idCiudad == "null" ? "0" : idCiudad;

                    if (string.IsNullOrEmpty(nombreTabla))
                    {
                        sql = string.Format(@"
                            select fecha, formato, conteo, nombreCompletoUsuario 
                            from (
                                select cast(a.fechaRadicacionFuan as date) as fecha, 'Afiliación' as formato, count(*) as conteo, 
	                                (b.primerApellidoUsuario + ' ' + b.segundoApellidoUsuario + ' ' + 
	                                 b.primerNombreUsuario + ' ' + b.segundoNombreUsuario) as nombreCompletoUsuario
                                from FUN.Fuan as a 
	                                left join SEC.Usuario as b on a.idUsuario = b.idUsuario 
                                {0} 
                                group by a.fechaRadicacionFuan, b.primerApellidoUsuario, b.segundoApellidoUsuario, 
	                                b.primerNombreUsuario, b.segundoNombreUsuario 
                                union
                                select cast(a.fechaFuanReporteNovedad as date) as fecha, 'Novedades' as formato, count(*) as conteo, 
	                                (b.primerApellidoUsuario + ' ' + b.segundoApellidoUsuario + ' ' + 
	                                 b.primerNombreUsuario + ' ' + b.segundoNombreUsuario) as nombreCompletoUsuario
                                from FUN.FuanReporteNovedad as a 
	                                left join SEC.Usuario as b on a.idUsuario = b.idUsuario 
                                {0} 
                                group by a.fechaFuanReporteNovedad, b.primerApellidoUsuario, b.segundoApellidoUsuario, 
	                                b.primerNombreUsuario, b.segundoNombreUsuario 
                                union
                                select cast(a.fechaVisitaHfdfr as date) as fecha, 'Historia Familiar para Detección de Factores de Riesgo' as formato, count(*) as conteo, 
	                                (b.primerApellidoUsuario + ' ' + b.segundoApellidoUsuario + ' ' + 
	                                 b.primerNombreUsuario + ' ' + b.segundoNombreUsuario) as nombreCompletoUsuario
                                from FUN.InfoHfdfr as a 
	                                left join SEC.Usuario as b on a.idUsuario = b.idUsuario 
                                {0} 
                                group by a.fechaVisitaHfdfr, b.primerApellidoUsuario, b.segundoApellidoUsuario, 
	                                b.primerNombreUsuario, b.segundoNombreUsuario 
                                union
                                select cast(a.fechaInfoIfppir as date) as fecha, 'Identificación y Focalización de pacientes para programas de intervención del riesgo' as formato, count(*) as conteo, 
	                                (b.primerApellidoUsuario + ' ' + b.segundoApellidoUsuario + ' ' + 
	                                 b.primerNombreUsuario + ' ' + b.segundoNombreUsuario) as nombreCompletoUsuario
                                from FUN.InfoIfppir as a 
	                                left join SEC.Usuario as b on a.idUsuario = b.idUsuario 
                                {0} 
                                group by a.fechaInfoIfppir, b.primerApellidoUsuario, b.segundoApellidoUsuario, 
	                                b.primerNombreUsuario, b.segundoNombreUsuario 
                                union
                                select cast(a.fechaAtencionPurisu as date) as fecha, 'Planilla Única de Registro de Información y Servicios al Usuario' as formato, count(*) as conteo, 
	                                (b.primerApellidoUsuario + ' ' + b.segundoApellidoUsuario + ' ' + 
	                                 b.primerNombreUsuario + ' ' + b.segundoNombreUsuario) as nombreCompletoUsuario
                                from FUN.InfoPurisu as a 
	                                left join SEC.Usuario as b on a.idUsuario = b.idUsuario 
                                {0} 
                                group by a.fechaAtencionPurisu, b.primerApellidoUsuario, b.segundoApellidoUsuario, 
	                                b.primerNombreUsuario, b.segundoNombreUsuario 
                                union
                                select cast(a.fechaHoraEncuestaIps as date) as fecha, 'Encuesta de Satisfacción de usuario de la I.P.S de primer Nivel' as formato, count(*) as conteo, 
	                                (b.primerApellidoUsuario + ' ' + b.segundoApellidoUsuario + ' ' + 
	                                 b.primerNombreUsuario + ' ' + b.segundoNombreUsuario) as nombreCompletoUsuario
                                from FUN.EncuestaIps as a 
	                                left join SEC.Usuario as b on a.idUsuario = b.idUsuario 
                                {0} 
                                group by a.fechaHoraEncuestaIps, b.primerApellidoUsuario, b.segundoApellidoUsuario, 
	                                b.primerNombreUsuario, b.segundoNombreUsuario 
                                union
                                select cast(a.fechaHoraEncuestaEps as date) as fecha, 'Encuesta de Satisfacción de usuario de la EPS-S' as formato, count(*) as conteo, 
	                                (b.primerApellidoUsuario + ' ' + b.segundoApellidoUsuario + ' ' + 
	                                 b.primerNombreUsuario + ' ' + b.segundoNombreUsuario) as nombreCompletoUsuario
                                from FUN.EncuestaEps as a 
	                                left join SEC.Usuario as b on a.idUsuario = b.idUsuario 
                                {0} 
                                group by a.fechaHoraEncuestaEps, b.primerApellidoUsuario, b.segundoApellidoUsuario, 
	                                b.primerNombreUsuario, b.segundoNombreUsuario 
                                union 
                                select cast(a.fechaAsistenciaGeneral as date) as fecha, 'Lista asistencia general' as formato, count(*) as conteo, 
	                                (b.primerApellidoUsuario + ' ' + b.segundoApellidoUsuario + ' ' + 
	                                 b.primerNombreUsuario + ' ' + b.segundoNombreUsuario) as nombreCompletoUsuario
                                from FUN.AsistenciaGeneral as a 
	                                left join SEC.Usuario as b on a.idUsuario = b.idUsuario 
                                {0} 
                                group by a.fechaAsistenciaGeneral, b.primerApellidoUsuario, b.segundoApellidoUsuario, 
	                                b.primerNombreUsuario, b.segundoNombreUsuario
                            ) as a 
                            {1}
                        ",
                            (Convert.ToInt32(idUsuario) > 0 ? "where (a.idUsuario = " + idUsuario.ToString() + ")" : ""),
                            "where (cast(a.fecha as date) between cast('" + fechaInicio + "' as date) and cast('" + fechaFin + "' as date))"
                            );
                    }
                    else
                    {
                        var nombreCampoFecha = "";
                        var nombreDescTabla = "";

                        switch (nombreTabla)
                        {
                            case "Fuan":
                                nombreCampoFecha = "fechaRadicacionFuan";
                                nombreDescTabla = "Afiliación";
                                break;
                            case "FuanReporteNovedad":
                                nombreCampoFecha = "fechaFuanReporteNovedad";
                                nombreDescTabla = "Novedades";
                                break;
                            case "InfoHfdfr":
                                nombreCampoFecha = "fechaVisitaHfdfr";
                                nombreDescTabla = "Historia Familiar para Detección de Factores de Riesgo";
                                break;
                            case "InfoIfppir":
                                nombreCampoFecha = "fechaInfoIfppir";
                                nombreDescTabla = "Identificación y Focalización de pacientes para programas de intervención del riesgo";
                                break;
                            case "InfoPurisu":
                                nombreCampoFecha = "fechaAtencionPurisu";
                                nombreDescTabla = "Planilla Única de Registro de Información y Servicios al Usuario";
                                break;
                            case "EncuestaIps":
                                nombreCampoFecha = "fechaHoraEncuestaIps";
                                nombreDescTabla = "Encuesta de Satisfacción de usuario de la I.P.S de primer Nivel";
                                break;
                            case "EncuestaEps":
                                nombreCampoFecha = "fechaHoraEncuestaEps";
                                nombreDescTabla = "Encuesta de Satisfacción de usuario de la EPS-S";
                                break;
                            case "AsistenciaGeneral":
                                nombreCampoFecha = "fechaAsistenciaGeneral";
                                nombreDescTabla = "Lista asistencia general";
                                break;
                        }
                        sql = string.Format(@"
                            select fecha, formato, conteo, nombreCompletoUsuario 
                            from (
                                select cast(a.{3} as date) as fecha, '{4}' as formato, count(*) as conteo, 
	                                (b.primerApellidoUsuario + ' ' + b.segundoApellidoUsuario + ' ' + 
	                                 b.primerNombreUsuario + ' ' + b.segundoNombreUsuario) as nombreCompletoUsuario
                                from FUN.{2} as a 
	                                left join SEC.Usuario as b on a.idUsuario = b.idUsuario 
                                {0} 
                                group by a.{3}, b.primerApellidoUsuario, b.segundoApellidoUsuario, 
	                                b.primerNombreUsuario, b.segundoNombreUsuario 
                            ) as a 
                            {1}
                        ",
                            (Convert.ToInt32(idUsuario) > 0 ? "where (a.idUsuario = " + idUsuario.ToString() + ")" : ""),
                            "where (cast(a.fecha as date) between cast('" + fechaInicio + "' as date) and cast('" + fechaFin + "' as date))",
                            nombreTabla,
                            nombreCampoFecha,
                            nombreDescTabla
                            );
                    }

                    var datos17 = db.Database.SqlQuery<GestionFormato>(sql).ToList();

                    dataSource = new ReportDataSource("DataSet1", datos17);

                    this.ReportViewer1.LocalReport.ReportPath = "Reportes/GestionFormato.rdlc";
                    this.ReportViewer1.LocalReport.DataSources.Add(dataSource);

                    break;
                case 18:
                    fechaInicio = Request.Params.Get("fechaInicio");
                    fechaFin = Request.Params.Get("fechaFin");
                    DateTime inicio = Convert.ToDateTime(fechaInicio);
                    DateTime fin = Convert.ToDateTime(fechaFin);
                    idCiudad = Request.Params.Get("idCiudad");

                    var res = db.InfoIfppir.Where(f => f.gestanteIfppir == true && f.fechaInfoIfppir >= inicio && f.fechaInfoIfppir <= fin)
                        .Select(r => new
                        {
                            r.fechaInfoIfppir,
                            r.FuanAfiliado.Ciudad.Departamento.nombreDepartamento,
                            r.FuanAfiliado.Ciudad.nombreCiudad,
                            r.FuanAfiliado.numCarnetFuanAfiliado,
                            nombreCompletoAfiliado = r.FuanAfiliado.primerNombreFuanAfiliado + " " + r.FuanAfiliado.segundoNombreFuanAfiliado + " " +
                                r.FuanAfiliado.primerApellidoFuanAfiliado + " " + r.FuanAfiliado.segundoApellidoFuanAfiliado,
                            r.FuanAfiliado.TipoIdentificacion.codigoTipoIdentificacion,
                            r.FuanAfiliado.identificacionFuanAfiliado,
                            r.fechaAplicacionIfppir,
                            r.FuanAfiliado.telefonoFuanAfiliado,
                            r.FuanAfiliado.celularFuanAfiliado,
                            r.FuanAfiliado.fechaNacimientoFuanAfiliado,
                            r.furIfppir,
                            r.fppIfppir,
                            preguntas = r.IfppirRespuestaFactor.Select(p => new
                            {
                                p.PreguntasSubFactorRiesgo.codigoPreguntasSubFactorRiesgo,
                                p.PreguntasSubFactorRiesgo.descripcionPreguntasSubFactorRiesgo,
                                p.respuestaSiIfppirRespuestaFactor,
                                p.respuestaNoIfppirRespuestaFactor
                            })
                            .ToList()
                        })
                        .ToList();

                    var datos18 = new List<ReporteGestanteModel>();

                    if (idCiudad != "null")
                    {
                        var ciudad = Convert.ToInt32(idCiudad);
                        res = db.InfoIfppir.Where(f => f.gestanteIfppir == true && f.fechaInfoIfppir >= inicio && f.fechaInfoIfppir <= fin && f.FuanAfiliado.idCiudad == ciudad)
                        .Select(r => new
                        {
                            r.fechaInfoIfppir,
                            r.FuanAfiliado.Ciudad.Departamento.nombreDepartamento,
                            r.FuanAfiliado.Ciudad.nombreCiudad,
                            r.FuanAfiliado.numCarnetFuanAfiliado,
                            nombreCompletoAfiliado = r.FuanAfiliado.primerNombreFuanAfiliado + " " + r.FuanAfiliado.segundoNombreFuanAfiliado + " " +
                                r.FuanAfiliado.primerApellidoFuanAfiliado + " " + r.FuanAfiliado.segundoApellidoFuanAfiliado,
                            r.FuanAfiliado.TipoIdentificacion.codigoTipoIdentificacion,
                            r.FuanAfiliado.identificacionFuanAfiliado,
                            r.fechaAplicacionIfppir,
                            r.FuanAfiliado.telefonoFuanAfiliado,
                            r.FuanAfiliado.celularFuanAfiliado,
                            r.FuanAfiliado.fechaNacimientoFuanAfiliado,
                            r.furIfppir,
                            r.fppIfppir,
                            preguntas = r.IfppirRespuestaFactor.Select(p => new
                            {
                                p.PreguntasSubFactorRiesgo.codigoPreguntasSubFactorRiesgo,
                                p.PreguntasSubFactorRiesgo.descripcionPreguntasSubFactorRiesgo,
                                p.respuestaSiIfppirRespuestaFactor,
                                p.respuestaNoIfppirRespuestaFactor
                            })
                            .ToList()
                        })
                        .ToList();
                    }
                    res.ForEach(r =>
                    {
                        var item = new ReporteGestanteModel();

                        item.nombreDepartamento = r.nombreDepartamento;
                        item.nombreCiudad = r.nombreCiudad;
                        item.numCarnetFuanAfiliado = r.numCarnetFuanAfiliado;
                        item.nombreCompletoAfiliado = r.nombreCompletoAfiliado;
                        item.edadAfiliado = DateTime.Today.AddTicks(-r.fechaNacimientoFuanAfiliado.Ticks).Year - 1;
                        item.codigoTipoIdentificacion = r.codigoTipoIdentificacion;
                        item.identificacionFuanAfiliado = r.identificacionFuanAfiliado;
                        item.fechaAplicacionIfppir = r.fechaAplicacionIfppir;
                        item.telefonoFuanAfiliado = r.telefonoFuanAfiliado;
                        item.celularFuanAfiliado = r.celularFuanAfiliado;
                        item.furIfppir = r.furIfppir;
                        item.fppIfppir = r.fppIfppir;

                        var fechaInfo = Convert.ToDateTime(r.fechaAplicacionIfppir);//FECHA DE LA VISITA
                        var fur = Convert.ToDateTime(r.furIfppir);//FECHA DE ULTIMA MENSTRUACION 
                        item.edadGestacional = (int)(fechaInfo - fur).TotalDays / 7;
                        item.totalRiesgo = 0;
                        if (item.edadAfiliado < 16)
                        {
                            item.totalRiesgo += 1;
                        }
                        else if (item.edadAfiliado >= 16 && item.edadAfiliado <= 35)
                        {
                            item.totalRiesgo += 0;
                        }
                        else if (item.edadAfiliado > 35)
                        {
                            item.totalRiesgo += 2;
                        }

                        r.preguntas.ForEach(p =>
                        {
                            switch (p.codigoPreguntasSubFactorRiesgo)
                            {
                                case "89":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        item.totalRiesgo += 1;
                                    }
                                    break;
                                case "90":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        item.totalRiesgo += 0;
                                    }
                                    break;
                                case "91":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        item.totalRiesgo += 2;
                                    }
                                    break;
                                case "92":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        item.pregunta92 = 1;
                                        item.totalRiesgo += 1;
                                    }
                                    else
                                    {
                                        item.pregunta92 = 0;
                                    }
                                    break;
                                case "93":

                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        item.pregunta93 = 1;
                                        item.totalRiesgo += 1;
                                    }
                                    else
                                    {
                                        item.pregunta93 = 0;
                                    }
                                    break;
                                case "95":

                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        item.pregunta95 = 1;
                                        item.totalRiesgo += 1;
                                    }
                                    else
                                    {
                                        item.pregunta95 = 0;
                                    }
                                    break;
                                case "97":

                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        item.pregunta97 = 1;
                                        item.totalRiesgo += 1;
                                    }
                                    else
                                    {
                                        item.pregunta97 = 0;
                                    }
                                    break;
                                case "98":

                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        item.pregunta98 = 1;
                                        item.totalRiesgo += 1;
                                    }
                                    else
                                    {
                                        item.pregunta98 = 0;
                                    }
                                    break;
                                case "99":

                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        item.pregunta99 = 1;
                                        item.totalRiesgo += 1;
                                    }
                                    else
                                    {
                                        item.pregunta99 = 0;
                                    }
                                    break;
                                case "101":

                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        item.pregunta101 = 1;
                                        item.totalRiesgo += 1;
                                    }
                                    else
                                    {
                                        item.pregunta101 = 0;
                                    }
                                    break;
                                case "102":

                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        item.pregunta102 = 1;
                                        item.totalRiesgo += 1;
                                    }
                                    else
                                    {
                                        item.pregunta102 = 0;
                                    }
                                    break;
                                case "103":

                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        item.pregunta103 = 2;
                                        item.totalRiesgo += 2;
                                    }
                                    else
                                    {
                                        item.pregunta103 = 0;
                                    }
                                    break;
                                case "104":

                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        item.pregunta104 = 3;
                                        item.totalRiesgo += 3;
                                    }
                                    else
                                    {
                                        item.pregunta104 = 0;
                                    }
                                    break;
                                case "105":

                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        item.pregunta105 = 1;
                                        item.totalRiesgo += 1;
                                    }
                                    else
                                    {
                                        item.pregunta105 = 0;
                                    }
                                    break;
                                case "106":

                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        item.pregunta106 = 2;
                                        item.totalRiesgo += 2;
                                    }
                                    else
                                    {
                                        item.pregunta106 = 0;
                                    }
                                    break;
                                case "107":

                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        item.pregunta107 = 1;
                                        item.totalRiesgo += 1;
                                    }
                                    else
                                    {
                                        item.pregunta107 = 0;
                                    }
                                    break;
                                case "108":

                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        item.pregunta108 = 2;
                                        item.totalRiesgo += 2;
                                    }
                                    else
                                    {
                                        item.pregunta108 = 0;
                                    }
                                    break;
                                case "109":

                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        item.pregunta109 = 2;
                                        item.totalRiesgo += 2;
                                    }
                                    else
                                    {
                                        item.pregunta109 = 0;
                                    }
                                    break;
                                case "110":

                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        item.pregunta110 = 0;
                                        item.totalRiesgo += 0;
                                    }
                                    else
                                    {
                                        item.pregunta110 = 0;
                                    }
                                    break;
                                case "111":

                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        item.pregunta111 = 3;
                                        item.totalRiesgo += 3;
                                    }
                                    else
                                    {
                                        item.pregunta111 = 0;
                                    }
                                    break;
                                case "112":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        item.totalRiesgo += 3;
                                    }
                                    break;
                                case "118":
                                case "119":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        item.totalRiesgo += 1;
                                    }
                                    break;
                                case "120":

                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        item.pregunta120 = 1;
                                        item.totalRiesgo += 1;
                                    }
                                    else
                                    {
                                        item.pregunta120 = 0;
                                    }
                                    break;
                            }
                        });

                        datos18.Add(item);
                    });

                    dataSource = new ReportDataSource("DataSet1", datos18);

                    this.ReportViewer1.LocalReport.ReportPath = "Reportes/ReporteGestante.rdlc";
                    this.ReportViewer1.LocalReport.DataSources.Add(dataSource);

                    break;
                case 19:
                    fechaInicio = Request.Params.Get("fechaInicio");
                    fechaFin = Request.Params.Get("fechaFin");
                    idCiudad = Request.Params.Get("idCiudad");
                    idCiudad = idCiudad == "null" ? " " : " and (c.idCiudad = " + idCiudad + ")";

                    sql = @"SELECT d.nombreDepartamento, c.nombreCiudad, a.fechaAplicacionIfppir, b.numCarnetFuanAfiliado, e.codigoTipoIdentificacion, b.identificacionFuanAfiliado, 
	                            b.primerNombreFuanAfiliado, b.segundoNombreFuanAfiliado, b.primerApellidoFuanAfiliado, b.segundoApellidoFuanAfiliado,
	                            b.fechaNacimientoFuanAfiliado, f.codigoTipoSexo, cast(datediff(dd,b.fechaNacimientoFuanAfiliado,GETDATE()) / 365.25 as int) as edadAfiliado, isnull(a.pesoIfppir, 0) as pesoIfppir, isnull(a.tallaIfppir, 0) as tallaIfppir, isnull(a.perimetroAbdominalIfppir, 0), isnull(a.sistolicaIfppir, 0) as sistolicaIfppir, 
                                isnull(a.diastolicaIfppir, 0) as diastolicaIfppir, isnull(a.masaCorporalIfppir, 0) as masaCorporalIfppir,
	                            (g.primerNombreUsuario + ' ' + g.segundoNombreUsuario + ' ' + g.primerApellidoUsuario + ' ' + g.segundoApellidoUsuario) as diligenciadoPor,
	                            (g.primerNombreUsuario + ' ' + g.segundoNombreUsuario + ' ' + g.primerApellidoUsuario + ' ' + g.segundoApellidoUsuario) as digitadoPor,
	                            a.fechaInfoIfppir
                            FROM FUN.InfoIfppir as a 
	                            left join FUN.FuanAfiliado as b on a.idFuanAfiliado = b.idFuanAfiliado 
	                            left join ADM.Ciudad as c on b.idCiudad = c.idCiudad 
	                            left join ADM.Departamento as d on c.idDepartamento = d.idDepartamento 
	                            left join PAR.TipoIdentificacion as e on b.idTipoIdentificacion = e.idTipoIdentificacion 
	                            left join PAR.TipoSexo as f on b.idTipoSexo = f.idTipoSexo 
	                            left join SEC.Usuario as g on a.idUsuario = g.idUsuario 
                            where(cast(a.fechaInfoIfppir as date) between cast('" + fechaInicio + "' as date) and cast('" + fechaFin + "' as date))" + idCiudad;

                    var datos19 = db.Database.SqlQuery<ReporteFichaIdentificacion>(sql).ToList();
                    List<ReporteFichaIdentificacion> dataFicha = new List<ReporteFichaIdentificacion>();
                    foreach (var item in datos19)
                    {
                        item.nombreCompletoAfiliado = item.primerNombreFuanAfiliado + " " + item.segundoNombreFuanAfiliado + " " + item.primerApellidoFuanAfiliado + " " + item.segundoApellidoFuanAfiliado;
                    }

                    dataSource = new ReportDataSource("DataSet1", datos19);
                    this.ReportViewer1.LocalReport.ReportPath = "Reportes/FichaIdentificacion.rdlc";
                    this.ReportViewer1.LocalReport.DataSources.Add(dataSource);

                    break;
                case 20:
                    fechaInicio = Request.Params.Get("fechaInicio");
                    fechaFin = Request.Params.Get("fechaFin");
                    idCiudad = Request.Params.Get("idCiudad");
                    idCiudad = idCiudad == "null" ? " " : " and (c.idCiudad = " + idCiudad + ")";
                    sql = @"SELECT d.nombreDepartamento, c.nombreCiudad, a.fechaVisitaHfdfr, 
	                            (g.primerNombreUsuario + ' ' + g.segundoNombreUsuario + ' ' + g.primerApellidoUsuario + ' ' + g.segundoApellidoUsuario) as diligenciadoPor,
	                            b.numCarnetFuanAfiliado, e.codigoTipoIdentificacion, b.identificacionFuanAfiliado,
	                            b.primerNombreFuanAfiliado, b.segundoNombreFuanAfiliado, b.primerApellidoFuanAfiliado, b.segundoApellidoFuanAfiliado, cast(1 as bit) as estadoAfiliado,
	                            (g.primerNombreUsuario + ' ' + g.segundoNombreUsuario + ' ' + g.primerApellidoUsuario + ' ' + g.segundoApellidoUsuario) as digitadoPor,
	                            a.fechaInfoHfdfr as fechaDigitacion
                            FROM FUN.InfoHfdfr as a 
	                            left join FUN.FuanAfiliado as b on a.idFuanAfiliado = b.idFuanAfiliado 
	                            left join ADM.Ciudad as c on b.idCiudad = c.idCiudad 
	                            left join ADM.Departamento as d on c.idDepartamento = d.idDepartamento 
	                            left join PAR.TipoIdentificacion as e on b.idTipoIdentificacion = e.idTipoIdentificacion 
	                            left join SEC.Usuario as g on a.idUsuario = g.idUsuario 
                            where(cast(a.fechaInfoHfdfr as date) between cast('" + fechaInicio + "' as date) and cast('" + fechaFin + "' as date))" + idCiudad;

                    var datos20 = db.Database.SqlQuery<ConsolidadoFactorRiesgo>(sql).ToList();

                    dataSource = new ReportDataSource("DataSet1", datos20);

                    this.ReportViewer1.LocalReport.ReportPath = "Reportes/ConsolidadoFactorRiesgo.rdlc";
                    this.ReportViewer1.LocalReport.DataSources.Add(dataSource);

                    break;
                case 21:
                    fechaInicio = Request.Params.Get("fechaInicio");
                    fechaFin = Request.Params.Get("fechaFin");
                    DateTime finicio = Convert.ToDateTime(fechaInicio);
                    DateTime ffin = Convert.ToDateTime(fechaFin);
                    idCiudad = Request.Params.Get("idCiudad");

                    var resFindrisk = db.InfoIfppir.Where(f => f.fechaInfoIfppir >= finicio && f.fechaInfoIfppir <= ffin)
                        .Select(r => new
                        {
                            r.fechaInfoIfppir,
                            r.FuanAfiliado.Ciudad.Departamento.nombreDepartamento,
                            r.FuanAfiliado.Ciudad.nombreCiudad,
                            r.FuanAfiliado.numCarnetFuanAfiliado,
                            r.FuanAfiliado.primerNombreFuanAfiliado,
                            r.FuanAfiliado.segundoNombreFuanAfiliado,
                            r.FuanAfiliado.primerApellidoFuanAfiliado,
                            r.FuanAfiliado.segundoApellidoFuanAfiliado,
                            r.FuanAfiliado.TipoIdentificacion.codigoTipoIdentificacion,
                            r.FuanAfiliado.identificacionFuanAfiliado,
                            r.fechaAplicacionIfppir,
                            r.FuanAfiliado.telefonoFuanAfiliado,
                            r.FuanAfiliado.celularFuanAfiliado,
                            r.FuanAfiliado.fechaNacimientoFuanAfiliado,
                            r.FuanAfiliado.TipoSexo.codigoTipoSexo,
                            r.FuanAfiliado.GrupoPoblacional.nombreGrupoPoblacional,
                            r.FuanAfiliado.CondicionDiscapacidad.nombreCondicionDiscapacidad,
                            r.FuanAfiliado.TipoZona.nombreTipoZona,
                            r.FuanAfiliado.direccionFuanAfiliado,
                            r.pesoIfppir,
                            r.tallaIfppir,
                            r.masaCorporalIfppir,
                            r.perimetroAbdominalIfppir,
                            preguntas = r.IfppirRespuestaFactor.Select(p => new
                            {
                                p.PreguntasSubFactorRiesgo.codigoPreguntasSubFactorRiesgo,
                                p.PreguntasSubFactorRiesgo.descripcionPreguntasSubFactorRiesgo,
                                p.respuestaSiIfppirRespuestaFactor,
                                p.respuestaNoIfppirRespuestaFactor
                            })
                            .ToList()
                        })
                        .ToList();

                    var datos21 = new List<ReporteFindriskModel>();

                    if (idCiudad != "null")
                    {
                        var ciudad = Convert.ToInt32(idCiudad);
                        resFindrisk = db.InfoIfppir.Where(f => f.fechaInfoIfppir >= finicio && f.fechaInfoIfppir <= ffin && f.FuanAfiliado.idCiudad == ciudad)
                        .Select(r => new
                        {
                            r.fechaInfoIfppir,
                            r.FuanAfiliado.Ciudad.Departamento.nombreDepartamento,
                            r.FuanAfiliado.Ciudad.nombreCiudad,
                            r.FuanAfiliado.numCarnetFuanAfiliado,
                            r.FuanAfiliado.primerNombreFuanAfiliado,
                            r.FuanAfiliado.segundoNombreFuanAfiliado,
                            r.FuanAfiliado.primerApellidoFuanAfiliado,
                            r.FuanAfiliado.segundoApellidoFuanAfiliado,
                            r.FuanAfiliado.TipoIdentificacion.codigoTipoIdentificacion,
                            r.FuanAfiliado.identificacionFuanAfiliado,
                            r.fechaAplicacionIfppir,
                            r.FuanAfiliado.telefonoFuanAfiliado,
                            r.FuanAfiliado.celularFuanAfiliado,
                            r.FuanAfiliado.fechaNacimientoFuanAfiliado,
                            r.FuanAfiliado.TipoSexo.codigoTipoSexo,
                            r.FuanAfiliado.GrupoPoblacional.nombreGrupoPoblacional,
                            r.FuanAfiliado.CondicionDiscapacidad.nombreCondicionDiscapacidad,
                            r.FuanAfiliado.TipoZona.nombreTipoZona,
                            r.FuanAfiliado.direccionFuanAfiliado,
                            r.pesoIfppir,
                            r.tallaIfppir,
                            r.masaCorporalIfppir,
                            r.perimetroAbdominalIfppir,
                            preguntas = r.IfppirRespuestaFactor.Select(p => new
                            {
                                p.PreguntasSubFactorRiesgo.codigoPreguntasSubFactorRiesgo,
                                p.PreguntasSubFactorRiesgo.descripcionPreguntasSubFactorRiesgo,
                                p.respuestaSiIfppirRespuestaFactor,
                                p.respuestaNoIfppirRespuestaFactor
                            })
                            .ToList()
                        })
                        .ToList();
                    }
                    resFindrisk.ForEach(r =>
                    {
                        var edad = DateTime.Today.AddTicks(-r.fechaNacimientoFuanAfiliado.Ticks).Year - 1;
                        if(edad >= 18)
                        {
                            var item = new ReporteFindriskModel();
                            item.fechaAplicacion = r.fechaAplicacionIfppir;
                            item.fechaInicio = finicio;
                            item.fechaFin = ffin;
                            item.numCarnetFuanAfiliado = r.numCarnetFuanAfiliado;
                            item.codigoTipoIdentificacion = r.codigoTipoIdentificacion;
                            item.identificacionFuanAfiliado = r.identificacionFuanAfiliado;
                            item.primerApellidoFuanAfiliado = r.primerApellidoFuanAfiliado;
                            item.segundoApellidoFuanAfiliado = r.segundoApellidoFuanAfiliado;
                            item.primerNombreFuanAfiliado = r.primerNombreFuanAfiliado;
                            item.segundoNombreFuanAfiliado = r.segundoNombreFuanAfiliado;
                            item.fechaNacimientoFuanAfiliado = r.fechaNacimientoFuanAfiliado;
                            item.edadAfiliado = DateTime.Today.AddTicks(-r.fechaNacimientoFuanAfiliado.Ticks).Year - 1;
                            //Puntaje por edad
                            if (item.edadAfiliado < 45)
                            {
                                item.puntajeEdad = 0;
                                item.totalPuntaje += 0;
                            }
                            if (item.edadAfiliado >= 45 && item.edadAfiliado <= 54)
                            {
                                item.puntajeEdad = 2;
                                item.totalPuntaje += 2;
                            }
                            if (item.edadAfiliado >= 55 && item.edadAfiliado <= 64)
                            {
                                item.puntajeEdad = 3;
                                item.totalPuntaje += 3;
                            }
                            if (item.edadAfiliado > 64)
                            {
                                item.puntajeEdad = 4;
                                item.totalPuntaje += 4;
                            }
                            //puntaje por IMC
                            if (r.masaCorporalIfppir < 25) item.totalPuntaje += 0;
                            if (r.masaCorporalIfppir >= 25 && r.masaCorporalIfppir < 30) item.totalPuntaje += 1;
                            if (r.masaCorporalIfppir >= 30) item.totalPuntaje += 3;

                            //puntaje perimetro abdominal
                            if (r.codigoTipoSexo == "M")
                            {
                                if (r.perimetroAbdominalIfppir < 90)
                                {
                                    item.totalPuntaje += 0;
                                }
                                if (r.perimetroAbdominalIfppir >= 90 && r.perimetroAbdominalIfppir < 102)
                                {
                                    item.totalPuntaje += 3;
                                }
                                if (r.perimetroAbdominalIfppir > 102)
                                {
                                    item.totalPuntaje += 4;
                                }
                            }
                            else
                            {
                                if (r.perimetroAbdominalIfppir < 80)
                                {
                                    item.totalPuntaje += 0;
                                }
                                if (r.perimetroAbdominalIfppir >= 80 && r.perimetroAbdominalIfppir < 88)
                                {
                                    item.totalPuntaje += 3;
                                }
                                if (r.perimetroAbdominalIfppir > 88)
                                {
                                    item.totalPuntaje += 4;
                                }
                            }

                            item.codigoTipoSexo = r.codigoTipoSexo;
                            item.nombreGrupoPoblacional = r.nombreGrupoPoblacional;
                            item.nombreCondicionDiscapacidad = r.nombreCondicionDiscapacidad;
                            item.nombreTipoZona = r.nombreTipoZona;
                            item.direccionFuanAfiliado = r.direccionFuanAfiliado;
                            item.telefonoFuanAfiliado = r.telefonoFuanAfiliado;
                            item.nombreDepartamento = r.nombreDepartamento;
                            item.nombreCiudad = r.nombreCiudad;
                            item.pesoIfppir = r.pesoIfppir;
                            item.tallaIfppir = r.tallaIfppir;
                            //Clasificacion corporal
                            if (r.masaCorporalIfppir >= 0 && r.masaCorporalIfppir < 18)
                            {
                                item.clasificacionCorporal = 1;
                                item.clasificacionIMC = "Bajo peso";
                            }
                            if (r.masaCorporalIfppir >= 18 && r.masaCorporalIfppir < 25)
                            {
                                item.clasificacionCorporal = 2;
                                item.clasificacionIMC = "Normal";
                            }
                            if (r.masaCorporalIfppir >= 25 && r.masaCorporalIfppir < 27)
                            {
                                item.clasificacionCorporal = 3;
                                item.clasificacionIMC = "Sobrepeso";
                            }
                            if (r.masaCorporalIfppir >= 27 && r.masaCorporalIfppir < 30)
                            {
                                item.clasificacionCorporal = 4;
                                item.clasificacionIMC = "Obesidad grado 1";
                            }
                            if (r.masaCorporalIfppir >= 30 && r.masaCorporalIfppir < 40)
                            {
                                item.clasificacionCorporal = 5;
                                item.clasificacionIMC = "Obesidad grado 2";
                            }
                            if (r.masaCorporalIfppir >= 40 && r.masaCorporalIfppir < 100)
                            {
                                item.clasificacionCorporal = 6;
                                item.clasificacionIMC = "Obesidad grado 3. Extrema o Mórbida";
                            }
                            item.perimetroAbdominalIfppir = r.perimetroAbdominalIfppir;

                            r.preguntas.ForEach(p =>
                            {
                                switch (p.codigoPreguntasSubFactorRiesgo)
                                {
                                    case "27":
                                        if (p.respuestaSiIfppirRespuestaFactor)
                                        {
                                            item.pregunta27 = 2;
                                            item.totalPuntaje += 2;
                                        }
                                        else
                                        {
                                            item.pregunta27 = 0;
                                        }
                                        break;

                                    case "26":
                                        if (p.respuestaSiIfppirRespuestaFactor)
                                        {
                                            item.pregunta26 = 2;
                                            item.totalPuntaje += 2;
                                        }
                                        else
                                        {
                                            item.pregunta26 = 0;
                                        }
                                        break;

                                    case "125":
                                        if (p.respuestaNoIfppirRespuestaFactor)
                                        {
                                            item.pregunta125 = 2;
                                            item.totalPuntaje += 2;
                                        }
                                        else
                                        {
                                            item.pregunta125 = 0;
                                        }
                                        break;

                                    case "126":
                                        if (p.respuestaNoIfppirRespuestaFactor)
                                        {
                                            item.pregunta126 = 2;
                                            item.totalPuntaje += 2;
                                        }
                                        else
                                        {
                                            item.pregunta126 = 0;
                                        }
                                        break;

                                    case "127":
                                        if (p.respuestaSiIfppirRespuestaFactor)
                                        {
                                            item.pregunta125 = 0;
                                        }
                                        else
                                        {
                                            item.pregunta125 = 0;
                                        }
                                        break;

                                    case "128":
                                        if (item.pregunta27 == 2)
                                        {
                                            if (p.respuestaNoIfppirRespuestaFactor)
                                            {
                                                item.pregunta128 = 2;
                                                item.totalPuntaje += 2;
                                            }
                                            else
                                            {
                                                item.pregunta128 = 0;
                                            }
                                        }
                                        else
                                        {
                                            if (p.respuestaSiIfppirRespuestaFactor)
                                            {
                                                item.pregunta128 = 2;
                                                item.totalPuntaje += 2;
                                            }
                                            else
                                            {
                                                item.pregunta128 = 0;
                                            }
                                        }
                                        break;

                                    case "130":
                                        if (p.respuestaSiIfppirRespuestaFactor)
                                        {
                                            item.pregunta26 = 2;
                                            item.totalPuntaje += 2;
                                        }
                                        else
                                        {
                                            item.pregunta26 = 0;
                                        }
                                        break;

                                    case "131":
                                        if (p.respuestaSiIfppirRespuestaFactor)
                                        {
                                            item.pregunta26 = 2;
                                            item.totalPuntaje += 2;
                                        }
                                        else
                                        {
                                            item.pregunta26 = 0;
                                        }
                                        break;

                                    case "132":
                                        if (p.respuestaSiIfppirRespuestaFactor)
                                        {
                                            item.pregunta26 = 5;
                                            item.totalPuntaje += 5;
                                        }
                                        else
                                        {
                                            item.pregunta26 = 0;
                                        }
                                        break;
                                }
                            });

                            item.totalPuntajeEdad = item.totalPuntaje;
                            //RIESGO DIABETICO
                            item.riesgoDiabeticoEdad = item.totalPuntaje;
                            if (item.totalPuntaje < 7) item.clasificacionFindrisk = "Riesgo Bajo";
                            if (item.totalPuntaje >= 7 && item.totalPuntaje <= 11) item.clasificacionFindrisk = "Riesgo ligeramente Elevado";
                            if (item.totalPuntaje > 11 && item.totalPuntaje <= 14) item.clasificacionFindrisk = "Riesgo Moderado";
                            if (item.totalPuntaje > 14 && item.totalPuntaje <= 20) item.clasificacionFindrisk = "Riesgo Alto";
                            if (item.totalPuntaje > 20) item.clasificacionFindrisk = "Riesgo Muy Alto";

                            item.masaCorporalIfppir = r.masaCorporalIfppir;
                            item.IPS = "";

                            // Ciclo vital
                            if (item.edadAfiliado >= 0 && item.edadAfiliado <= 11) item.cicloVital = "Niñez";
                            if (item.edadAfiliado >= 12 && item.edadAfiliado <= 18) item.cicloVital = "Adolescencia";
                            if (item.edadAfiliado > 18) item.cicloVital = "Adultez";

                            datos21.Add(item);
                        }                        
                    });

                    dataSource = new ReportDataSource("DataSet1", datos21);

                    this.ReportViewer1.LocalReport.ReportPath = "Reportes/ReporteFindrisk.rdlc";
                    this.ReportViewer1.LocalReport.DataSources.Add(dataSource);
                    break;
                case 22:
                    fechaInicio = Request.Params.Get("fechaInicio");
                    fechaFin = Request.Params.Get("fechaFin");
                    DateTime frainicio = Convert.ToDateTime(fechaInicio);
                    DateTime frafin = Convert.ToDateTime(fechaFin);
                    idCiudad = Request.Params.Get("idCiudad");

                    var resFramingham = db.InfoIfppir.Where(f => f.fechaInfoIfppir >= frainicio && f.fechaInfoIfppir <= frafin)
                        .Select(r => new
                        {
                            r.fechaInfoIfppir,
                            r.FuanAfiliado.Ciudad.Departamento.nombreDepartamento,
                            r.FuanAfiliado.Ciudad.nombreCiudad,
                            r.FuanAfiliado.numCarnetFuanAfiliado,
                            r.FuanAfiliado.primerNombreFuanAfiliado,
                            r.FuanAfiliado.segundoNombreFuanAfiliado,
                            r.FuanAfiliado.primerApellidoFuanAfiliado,
                            r.FuanAfiliado.segundoApellidoFuanAfiliado,
                            r.FuanAfiliado.TipoIdentificacion.codigoTipoIdentificacion,
                            r.FuanAfiliado.identificacionFuanAfiliado,
                            r.fechaAplicacionIfppir,
                            r.FuanAfiliado.telefonoFuanAfiliado,
                            r.FuanAfiliado.celularFuanAfiliado,
                            r.FuanAfiliado.fechaNacimientoFuanAfiliado,
                            r.FuanAfiliado.TipoSexo.codigoTipoSexo,
                            r.FuanAfiliado.GrupoPoblacional.nombreGrupoPoblacional,
                            r.FuanAfiliado.CondicionDiscapacidad.nombreCondicionDiscapacidad,
                            r.FuanAfiliado.TipoZona.nombreTipoZona,
                            r.FuanAfiliado.direccionFuanAfiliado,
                            r.pesoIfppir,
                            r.tallaIfppir,
                            r.masaCorporalIfppir,
                            r.perimetroAbdominalIfppir,
                            r.colesterolTotalIfppir,
                            r.colesterolHdlIfppir,
                            r.colesterolLdlIfppir,
                            r.sistolicaIfppir,
                            r.diastolicaIfppir,
                            preguntas = r.IfppirRespuestaFactor.Select(p => new
                            {
                                p.PreguntasSubFactorRiesgo.codigoPreguntasSubFactorRiesgo,
                                p.PreguntasSubFactorRiesgo.descripcionPreguntasSubFactorRiesgo,
                                p.respuestaSiIfppirRespuestaFactor,
                                p.respuestaNoIfppirRespuestaFactor
                            })
                            .ToList()
                        })
                        .ToList();

                    var datos22 = new List<ReporteFraminghamModel>();

                    if (idCiudad != "null")
                    {
                        var ciudad = Convert.ToInt32(idCiudad);
                        resFramingham = db.InfoIfppir.Where(f => f.fechaInfoIfppir >= frainicio && f.fechaInfoIfppir <= frafin && f.FuanAfiliado.idCiudad == ciudad)
                        .Select(r => new
                        {
                            r.fechaInfoIfppir,
                            r.FuanAfiliado.Ciudad.Departamento.nombreDepartamento,
                            r.FuanAfiliado.Ciudad.nombreCiudad,
                            r.FuanAfiliado.numCarnetFuanAfiliado,
                            r.FuanAfiliado.primerNombreFuanAfiliado,
                            r.FuanAfiliado.segundoNombreFuanAfiliado,
                            r.FuanAfiliado.primerApellidoFuanAfiliado,
                            r.FuanAfiliado.segundoApellidoFuanAfiliado,
                            r.FuanAfiliado.TipoIdentificacion.codigoTipoIdentificacion,
                            r.FuanAfiliado.identificacionFuanAfiliado,
                            r.fechaAplicacionIfppir,
                            r.FuanAfiliado.telefonoFuanAfiliado,
                            r.FuanAfiliado.celularFuanAfiliado,
                            r.FuanAfiliado.fechaNacimientoFuanAfiliado,
                            r.FuanAfiliado.TipoSexo.codigoTipoSexo,
                            r.FuanAfiliado.GrupoPoblacional.nombreGrupoPoblacional,
                            r.FuanAfiliado.CondicionDiscapacidad.nombreCondicionDiscapacidad,
                            r.FuanAfiliado.TipoZona.nombreTipoZona,
                            r.FuanAfiliado.direccionFuanAfiliado,
                            r.pesoIfppir,
                            r.tallaIfppir,
                            r.masaCorporalIfppir,
                            r.perimetroAbdominalIfppir,
                            r.colesterolTotalIfppir,
                            r.colesterolHdlIfppir,
                            r.colesterolLdlIfppir,
                            r.sistolicaIfppir,
                            r.diastolicaIfppir,
                            preguntas = r.IfppirRespuestaFactor.Select(p => new
                            {
                                p.PreguntasSubFactorRiesgo.codigoPreguntasSubFactorRiesgo,
                                p.PreguntasSubFactorRiesgo.descripcionPreguntasSubFactorRiesgo,
                                p.respuestaSiIfppirRespuestaFactor,
                                p.respuestaNoIfppirRespuestaFactor
                            })
                            .ToList()
                        })
                        .ToList();
                    }
                    resFramingham.ForEach(r =>
                    {
                        var edad = DateTime.Today.AddTicks(-r.fechaNacimientoFuanAfiliado.Ticks).Year - 1;
                        if (edad >= 18)
                        {
                            var item = new ReporteFraminghamModel();
                            item.fechaAplicacion = r.fechaAplicacionIfppir;
                            item.fechaInicio = frainicio;
                            item.fechaFin = frafin;
                            item.nombreDepartamento = r.nombreDepartamento;
                            item.nombreCiudad = r.nombreCiudad;
                            item.numCarnetFuanAfiliado = r.numCarnetFuanAfiliado;
                            item.codigoTipoIdentificacion = r.codigoTipoIdentificacion;
                            item.identificacionFuanAfiliado = r.identificacionFuanAfiliado;
                            item.primerApellidoFuanAfiliado = r.primerApellidoFuanAfiliado;
                            item.segundoApellidoFuanAfiliado = r.segundoApellidoFuanAfiliado;
                            item.primerNombreFuanAfiliado = r.primerNombreFuanAfiliado;
                            item.segundoNombreFuanAfiliado = r.segundoNombreFuanAfiliado;
                            item.fechaNacimientoFuanAfiliado = r.fechaNacimientoFuanAfiliado;
                            item.edadAfiliado = DateTime.Today.AddTicks(-r.fechaNacimientoFuanAfiliado.Ticks).Year - 1;
                            //Puntaje por edad
                            if (item.edadAfiliado >= 18 && item.edadAfiliado <= 34)
                            {
                                item.totalPuntaje += -9;
                            }
                            if (item.edadAfiliado >= 35 && item.edadAfiliado <= 39)
                            {
                                item.totalPuntaje += -4;
                            }
                            if (item.edadAfiliado >= 40 && item.edadAfiliado <= 44)
                            {
                                item.totalPuntaje += 0;
                            }
                            if (item.edadAfiliado >= 45 && item.edadAfiliado <= 49)
                            {
                                item.totalPuntaje += 3;
                            }
                            if (item.edadAfiliado >= 50 && item.edadAfiliado <= 54)
                            {
                                item.totalPuntaje += 6;
                            }
                            if (item.edadAfiliado >= 55 && item.edadAfiliado <= 59)
                            {
                                item.totalPuntaje += 8;
                            }
                            r.preguntas.ForEach(p =>
                            {
                                switch (p.codigoPreguntasSubFactorRiesgo)
                                {
                                    case "41":
                                        if (p.respuestaSiIfppirRespuestaFactor)
                                        {
                                            if (item.edadAfiliado >= 18 && item.edadAfiliado <= 39)
                                            {
                                                item.totalPuntaje += 8;
                                            }
                                            if (item.edadAfiliado >= 40 && item.edadAfiliado <= 49)
                                            {
                                                item.totalPuntaje += 5;
                                            }
                                            if (item.edadAfiliado >= 50 && item.edadAfiliado <= 59)
                                            {
                                                item.totalPuntaje += 3;
                                            }
                                            if (item.edadAfiliado >= 60 && item.edadAfiliado <= 69)
                                            {
                                                item.totalPuntaje += 1;
                                            }
                                            if (item.edadAfiliado >= 70)
                                            {
                                                item.totalPuntaje += 1;
                                            }
                                        }
                                        break;

                                    case "133":
                                        if (p.respuestaSiIfppirRespuestaFactor)
                                        {
                                            double colesterol = 0;
                                            double colesterolHDL = 0;
                                            if (r.colesterolTotalIfppir != "")
                                            {
                                                colesterol = Convert.ToDouble(r.colesterolTotalIfppir);
                                            }
                                            if (r.colesterolHdlIfppir != "")
                                            {
                                                colesterolHDL = Convert.ToDouble(r.colesterolHdlIfppir);
                                            }
                                            if (item.edadAfiliado >= 18 && item.edadAfiliado <= 39)
                                            {
                                                if (colesterol < 160)
                                                {
                                                    item.colesterolTotal = 0;
                                                    item.totalPuntaje += 0;
                                                }
                                                else
                                                {
                                                    item.colesterolTotal = 4;
                                                    item.totalPuntaje += 4;
                                                }
                                            }
                                            if (item.edadAfiliado >= 40 && item.edadAfiliado <= 49)
                                            {
                                                if (colesterol < 160)
                                                {
                                                    item.colesterolTotal = 0;
                                                    item.totalPuntaje += 0;
                                                }
                                                else
                                                {
                                                    item.colesterolTotal = 3;
                                                    item.totalPuntaje += 3;
                                                }
                                            }
                                            if (item.edadAfiliado >= 50 && item.edadAfiliado <= 59)
                                            {
                                                if (colesterol < 160)
                                                {
                                                    item.colesterolTotal = 0;
                                                    item.totalPuntaje += 0;
                                                }
                                                else
                                                {
                                                    item.colesterolTotal = 2;
                                                    item.totalPuntaje += 2;
                                                }
                                            }
                                            if (item.edadAfiliado >= 60 && item.edadAfiliado <= 69)
                                            {
                                                if (colesterol < 160)
                                                {
                                                    item.colesterolTotal = 0;
                                                    item.totalPuntaje += 0;
                                                }
                                                else
                                                {
                                                    item.colesterolTotal = 1;
                                                    item.totalPuntaje += 1;
                                                }
                                            }
                                            if (item.edadAfiliado >= 70)
                                            {
                                                item.colesterolTotal = 0;
                                                item.totalPuntaje += 0;
                                            }

                                            //colesterol HDL
                                            if (colesterolHDL < 40)
                                            {
                                                item.colesterolH = 2;
                                                item.totalPuntaje += 2;
                                            }
                                            if (colesterolHDL >= 40 && colesterolHDL <= 49)
                                            {
                                                item.colesterolH = 1;
                                                item.totalPuntaje += 1;
                                            }
                                            if (colesterolHDL >= 50 && colesterolHDL <= 59)
                                            {
                                                item.colesterolH = 0;
                                                item.totalPuntaje += 0;
                                            }
                                            if (colesterolHDL > 60)
                                            {
                                                item.colesterolH = -1;
                                                item.totalPuntaje += -1;
                                            }
                                        }
                                        else
                                        {
                                            item.colesterolH = 1;
                                            item.totalPuntaje += 1;
                                        }
                                        break;

                                    case "128":
                                        if (p.respuestaSiIfppirRespuestaFactor)
                                        {
                                            if (r.sistolicaIfppir < 120) item.totalPuntaje += 0;
                                            if (r.sistolicaIfppir >= 120 && r.sistolicaIfppir <= 129) item.totalPuntaje += 1;
                                            if (r.sistolicaIfppir >= 130 && r.sistolicaIfppir <= 139) item.totalPuntaje += 2;
                                            if (r.sistolicaIfppir >= 140 && r.sistolicaIfppir <= 159) item.totalPuntaje += 2;
                                            if (r.sistolicaIfppir >= 160) item.totalPuntaje += 3;
                                        }
                                        else
                                        {
                                            if (r.sistolicaIfppir < 120) item.totalPuntaje += 0;
                                            if (r.sistolicaIfppir >= 120 && r.sistolicaIfppir <= 129) item.totalPuntaje += 0;
                                            if (r.sistolicaIfppir >= 130 && r.sistolicaIfppir <= 139) item.totalPuntaje += 1;
                                            if (r.sistolicaIfppir >= 140 && r.sistolicaIfppir <= 159) item.totalPuntaje += 1;
                                            if (r.sistolicaIfppir >= 160) item.totalPuntaje += 2;
                                        }
                                        break;
                                }
                            });
                            item.codigoTipoSexo = r.codigoTipoSexo;
                            item.nombreGrupoPoblacional = r.nombreGrupoPoblacional;
                            item.nombreCondicionDiscapacidad = r.nombreCondicionDiscapacidad;
                            item.nombreTipoZona = r.nombreTipoZona;
                            item.direccionFuanAfiliado = r.direccionFuanAfiliado;
                            item.telefonoFuanAfiliado = r.telefonoFuanAfiliado;
                            item.hta = r.sistolicaIfppir.ToString() + "/" + r.diastolicaIfppir.ToString();
                            item.puntajeTotal = item.colesterolTotal + item.colesterolH;
                            //Clasificacion corporal
                            if (r.masaCorporalIfppir >= 0 && r.masaCorporalIfppir < 18)
                            {
                                item.clasificacionIMC = "Bajo peso";
                            }
                            if (r.masaCorporalIfppir >= 18 && r.masaCorporalIfppir < 25)
                            {
                                item.clasificacionIMC = "Normal";
                            }
                            if (r.masaCorporalIfppir >= 25 && r.masaCorporalIfppir < 27)
                            {
                                item.clasificacionIMC = "Sobrepeso";
                            }
                            if (r.masaCorporalIfppir >= 27 && r.masaCorporalIfppir < 30)
                            {
                                item.clasificacionIMC = "Obesidad grado 1";
                            }
                            if (r.masaCorporalIfppir >= 30 && r.masaCorporalIfppir < 40)
                            {
                                item.clasificacionIMC = "Obesidad grado 2";
                            }
                            if (r.masaCorporalIfppir >= 40)
                            {
                                item.clasificacionIMC = "Obesidad grado 3. Extrema o Mórbida";
                            }
                            item.perimetroAbdominalIfppir = r.perimetroAbdominalIfppir;

                            //puntaje perimetro abdominal
                            if (r.codigoTipoSexo == "M")
                            {
                                if (r.perimetroAbdominalIfppir < 90)
                                {
                                    item.puntajePerimetroAbdominalIfppir += 0;
                                }
                                if (r.perimetroAbdominalIfppir >= 90 && r.perimetroAbdominalIfppir < 102)
                                {
                                    item.puntajePerimetroAbdominalIfppir += 3;
                                }
                                if (r.perimetroAbdominalIfppir > 102)
                                {
                                    item.puntajePerimetroAbdominalIfppir += 4;
                                }
                            }
                            else
                            {
                                if (r.perimetroAbdominalIfppir < 80)
                                {
                                    item.puntajePerimetroAbdominalIfppir += 0;
                                }
                                if (r.perimetroAbdominalIfppir >= 80 && r.perimetroAbdominalIfppir < 88)
                                {
                                    item.puntajePerimetroAbdominalIfppir += 3;
                                }
                                if (r.perimetroAbdominalIfppir > 88)
                                {
                                    item.puntajePerimetroAbdominalIfppir += 4;
                                }
                            }
                            item.puntajeFR = item.totalPuntaje;
                            //CLASIFICACION
                            if (item.puntajeFR < 0) item.clasificacionFR = "RIESGO BAJO";
                            if (item.puntajeFR == 0) item.clasificacionFR = "RIESGO BAJO";
                            if (item.puntajeFR == 1) item.clasificacionFR = "RIESGO BAJO";
                            if (item.puntajeFR == 2) item.clasificacionFR = "RIESGO BAJO";
                            if (item.puntajeFR == 3) item.clasificacionFR = "RIESGO BAJO";
                            if (item.puntajeFR == 4) item.clasificacionFR = "RIESGO BAJO";
                            if (item.puntajeFR == 5) item.clasificacionFR = "RIESGO BAJO";
                            if (item.puntajeFR == 6) item.clasificacionFR = "RIESGO BAJO";
                            if (item.puntajeFR == 7) item.clasificacionFR = "RIESGO BAJO";
                            if (item.puntajeFR == 8) item.clasificacionFR = "RIESGO BAJO";
                            if (item.puntajeFR == 9) item.clasificacionFR = "RIESGO BAJO";
                            if (item.puntajeFR == 10) item.clasificacionFR = "RIESGO BAJO";
                            if (item.puntajeFR == 11) item.clasificacionFR = "RIESGO MODERADO";
                            if (item.puntajeFR == 12) item.clasificacionFR = "RIESGO MODERADO";
                            if (item.puntajeFR == 13) item.clasificacionFR = "RIESGO MODERADO";
                            if (item.puntajeFR == 14) item.clasificacionFR = "RIESGO ALTO";
                            if (item.puntajeFR == 15) item.clasificacionFR = "RIESGO ALTO";
                            if (item.puntajeFR == 16) item.clasificacionFR = "RIESGO ALTO";
                            if (item.puntajeFR > 16) item.clasificacionFR = "RIESGO ALTO";

                            item.IPS = "";

                            // Ciclo vital
                            if (item.edadAfiliado >= 0 && item.edadAfiliado <= 11) item.cicloVital = "Niñez";
                            if (item.edadAfiliado >= 12 && item.edadAfiliado <= 18) item.cicloVital = "Adolescencia";
                            if (item.edadAfiliado > 18) item.cicloVital = "Adultez";

                            datos22.Add(item);
                        }
                    });

                    dataSource = new ReportDataSource("DataSet1", datos22);

                    this.ReportViewer1.LocalReport.ReportPath = "Reportes/ReporteFramingham.rdlc";
                    this.ReportViewer1.LocalReport.DataSources.Add(dataSource);
                    break;
                case 23:
                    fechaInicio = Request.Params.Get("fechaInicio");
                    fechaFin = Request.Params.Get("fechaFin");
                    idCiudad = Request.Params.Get("idCiudad");
                    idCiudad = idCiudad == "null" ? " " : " and (a.idCiudad = " + idCiudad + ")";

                    sql = @"select c.nombreDepartamento, b.nombreCiudad, fechaAtencionPurisu, 
	                            e.primerApellidoFuanAfiliado, e.segundoApellidoFuanAfiliado, e.primerNombreFuanAfiliado, e.segundoNombreFuanAfiliado, n.codigoTipoIdentificacion, e.identificacionFuanAfiliado, e.numCarnetFuanAfiliado, 
                                r.codigoTipoSexo, e.fechaNacimientoFuanAfiliado, (cast(datediff(dd, e.fechaNacimientoFuanAfiliado,GETDATE()) / 365.25 as int)) as edadFuanAfiliado, f.nombreTipoVisitaDomiciliaria, d.usisPurisu, d.ipsPrimariaPurisu, d.telefonicaPurisu, d.cauPurisu, d.actividadExtramuralPurisu, g.descripcionProgramaResolucion412, h.descripcionGrupoInteres, 
                                i.nombreSeguimientoProgramasIntervencionRiesgo, 
	                            (select motivoConsulta1 from dbo.fnMotivoConsulta(a.idInfoPurisu, d.idPurisu)) as motivoConsulta1,
	                            (select motivoConsulta2 from dbo.fnMotivoConsulta(a.idInfoPurisu, d.idPurisu)) as motivoConsulta2,
	                            (select motivoContacto1 from dbo.fnMotivoContacto(a.idInfoPurisu, d.idPurisu)) as motivoContacto1,
	                            (select motivoContacto2 from dbo.fnMotivoContacto(a.idInfoPurisu, d.idPurisu)) as motivoContacto2,
	                            d.numAutorizacionPurisu, j.nombreGruposFocales, k.nombreEje as nombreEje1, l.nombreUnidad as nombreUnidad1, m.nombreModulo as nombreModulo1, 
                                o.nombreEje as nombreEje2, p.nombreUnidad as nombreUnidad2, q.nombreModulo as nombreModulo2,
	                            (select piezaInformativa1 from dbo.fnPiezasInformativas(a.idInfoPurisu, d.idPurisu)) as piezaInformativa1, 
	                            (select piezaInformativa2 from dbo.fnPiezasInformativas(a.idInfoPurisu, d.idPurisu)) as piezaInformativa2, 
	                            (select piezaInformativa3 from dbo.fnPiezasInformativas(a.idInfoPurisu, d.idPurisu)) as piezaInformativa3,
                                (us.primerNombreUsuario + ' ' + us.segundoNombreUsuario + ' ' + us.primerApellidoUsuario + ' ' + us.segundoApellidoUsuario) as digitadoPor
                            from FUN.InfoPurisu as a 
	                            left join ADM.Ciudad as b on a.idCiudad = b.idCiudad 
	                            left join ADM.Departamento as c on b.idDepartamento = c.idDepartamento 
	                            inner join FUN.Purisu as d on a.idInfoPurisu = d.idInfoPurisu
	                            left join FUN.FuanAfiliado as e on d.idFuanAfiliado = e.idFuanAfiliado 
	                            left join PAR.TipoVisitaDomiciliaria as f on d.idTipoVisitaDomiciliaria = f.idTipoVisitaDomiciliaria 
	                            left join PAR.ProgramaResolucion412 as g on d.idProgramaResolucion412 = g.idProgramaResolucion412 
	                            left join PAR.GrupoInteres as h on d.idGrupoInteres = h.idGrupoInteres 
	                            left join PAR.SeguimientoProgramasIntervencionRiesgo as i on d.idSeguimientoProgramasIntervencionRiesgo = i.idSeguimientoProgramasIntervencionRiesgo 
	                            left join PAR.GruposFocales as j on d.idGruposFocales = j.idGruposFocales 
	                            left join PAR.Eje as k on d.idEje = k.idEje 
	                            left join PAR.Unidad as l on d.idUnidad = l.idUnidad 
	                            left join PAR.Modulo as m on d.idModulo = m.idModulo 
	                            left join PAR.TipoIdentificacion as n on e.idTipoIdentificacion = n.idTipoIdentificacion
	                            left join PAR.Eje as o on d.idEje1 = o.idEje 
	                            left join PAR.Unidad as p on d.idUnidad1 = p.idUnidad 
	                            left join PAR.Modulo as q on d.idModulo1 = q.idModulo 
	                            left join PAR.TipoSexo as r on e.idTipoSexo = r.idTipoSexo 
                                left join SEC.Usuario as us on a.idUsuario = us.idUsuario
                            where (cast(a.fechaAtencionPurisu as date) between cast('" + fechaInicio + "' as date) and cast('" + fechaFin + "' as date))" + idCiudad +
                            "order by a.idInfoPurisu";

                    var datos23 = db.Database.SqlQuery<PlanillaUnicaModel>(sql).ToList();

                    dataSource = new ReportDataSource("DataSet1", datos23);

                    this.ReportViewer1.LocalReport.ReportPath = "Reportes/ConsolidadoPlanillaUnica.rdlc";
                    this.ReportViewer1.LocalReport.DataSources.Add(dataSource);

                    break;
                case 24:
                    fechaInicio = Request.Params.Get("fechaInicio");
                    fechaFin = Request.Params.Get("fechaFin");
                    idCiudad = Request.Params.Get("idCiudad");
                    idCiudad = idCiudad == "null" ? " " : " and (a.idCiudad = " + idCiudad + ")";

                    sql = @"select c.nombreDepartamento, b.nombreCiudad, (d.codigoGruposFocales + ' - ' + d.nombreGruposFocales) as grupoFocal, 
	                            a.temaAsistenciaGeneral, (g.codigoEje + ' - ' + g.nombreEje) as eje,
	                            (f.codigoUnidad + ' - ' + f.nombreUnidad) as unidad,
                                e.codigoModulo as modulo, a.formadorAsistenciaGeneral, a.fechaAsistenciaGeneral,
	                            (i.primerNombreFuanAfiliado + ' ' + i.segundoApellidoFuanAfiliado) as nombreFuanAfiliado,
	                            j.codigoTipoIdentificacion, i.identificacionFuanAfiliado, h.areaEntidadListaAsistenciaGeneral, i.telefonoFuanAfiliado,
                                (us.primerNombreUsuario + ' ' + us.segundoNombreUsuario + ' ' + us.primerApellidoUsuario + ' ' + us.segundoApellidoUsuario) as digitadoPor
                            from FUN.AsistenciaGeneral as a 
	                            left join ADM.Ciudad as b on a.idCiudad = b.idCiudad 
	                            left join ADM.Departamento as c on b.idDepartamento = c.idDepartamento 
	                            left join PAR.GruposFocales as d on a.idGruposFocales = d.idGruposFocales 
	                            left join PAR.Modulo as e on a.idModulo = e.idModulo 
	                            left join PAR.Unidad as f on e.idUnidad = f.idUnidad 
	                            left join PAR.Eje as g on f.idEje = g.idEje 
	                            inner join FUN.ListaAsistenciaGeneral as h on a.idAsistenciaGeneral = h.idAsistenciaGeneral 
	                            left join FUN.FuanAfiliado as i on h.idFuanAfiliado = i.idFuanAfiliado 
	                            left join PAR.TipoIdentificacion as j on i.idTipoIdentificacion = j.idTipoIdentificacion
                                left join SEC.Usuario as us on a.idUsuario = us.idUsuario
                            where (cast(a.fechaAsistenciaGeneral as date) between cast('" + fechaInicio + "' as date) and cast('" + fechaFin + "' as date))" + idCiudad;

                    var datos24 = db.Database.SqlQuery<AsistenciaGeneralModel>(sql).ToList();

                    dataSource = new ReportDataSource("DataSet1", datos24);

                    this.ReportViewer1.LocalReport.ReportPath = "Reportes/ConsolidadoAsistenciaGeneral.rdlc";
                    this.ReportViewer1.LocalReport.DataSources.Add(dataSource);

                    break;
                case 25:
                    documento = Request.Params.Get("documento");
                    fechaFicha = Request.Params.Get("fechaFicha");
                    DateTime fecha = Convert.ToDateTime(fechaFicha);
                    var datos25 = new List<ReporteFichaIdentificacionIndividual>();
                    var afiliado = db.FuanAfiliado.Where(a => a.identificacionFuanAfiliado == documento).FirstOrDefault();
                    if (afiliado != null)
                    {
                        var fichaAfiliado = db.InfoIfppir.Where(f => f.fechaAplicacionIfppir >= fecha && f.idFuanAfiliado == afiliado.idFuanAfiliado)
                        .Select(r => new
                        {
                            r.FuanAfiliado.primerNombreFuanAfiliado,
                            r.FuanAfiliado.segundoNombreFuanAfiliado,
                            r.FuanAfiliado.primerApellidoFuanAfiliado,
                            r.FuanAfiliado.segundoApellidoFuanAfiliado,
                            r.FuanAfiliado.TipoIdentificacion.codigoTipoIdentificacion,
                            r.FuanAfiliado.identificacionFuanAfiliado,
                            r.FuanAfiliado.numCarnetFuanAfiliado,
                            r.FuanAfiliado.fechaNacimientoFuanAfiliado,
                            r.FuanAfiliado.Ciudad.Departamento.nombreDepartamento,
                            r.FuanAfiliado.Ciudad.nombreCiudad,
                            r.FuanAfiliado.direccionFuanAfiliado,
                            r.FuanAfiliado.telefonoFuanAfiliado,
                            r.FuanAfiliado.celularFuanAfiliado,
                            r.FuanAfiliado.puntajeSisbenFuanAfiliado,
                            r.razaIfppir,
                            r.escolaridadIfppir,
                            r.FuanAfiliado.TipoZona.nombreTipoZona,
                            r.FuanAfiliado.TipoSexo.codigoTipoSexo,
                            r.familiarCercanoIfppir,
                            r.telefonoFamiliarIfppir,
                            r.gestanteIfppir,
                            r.furIfppir,
                            r.fppIfppir,
                            r.colesterolTotalIfppir,
                            r.colesterolLdlIfppir,
                            r.colesterolHdlIfppir,
                            r.glicemiaIfppir,
                            r.gIfppir,
                            r.pIfppir,
                            r.cIfppir,
                            r.aIfppir,
                            r.fechaAplicacionIfppir,
                            r.pesoIfppir,
                            r.tallaIfppir,
                            r.masaCorporalIfppir,
                            r.perimetroAbdominalIfppir,
                            r.sistolicaIfppir,
                            r.diastolicaIfppir,
                            r.observacionIfppir,
                            r.firmaIfppir,
                            preguntas = r.IfppirRespuestaFactor.Select(p => new
                            {
                                p.PreguntasSubFactorRiesgo.codigoPreguntasSubFactorRiesgo,
                                p.PreguntasSubFactorRiesgo.descripcionPreguntasSubFactorRiesgo,
                                p.respuestaSiIfppirRespuestaFactor,
                                p.respuestaNoIfppirRespuestaFactor
                            })
                            .ToList()
                        })
                        .FirstOrDefault();
                        var newFicha = new ReporteFichaIdentificacionIndividual();
                        newFicha.primerNombreFuanAfiliado = fichaAfiliado.primerNombreFuanAfiliado;
                        newFicha.segundoNombreFuanAfiliado = fichaAfiliado.segundoNombreFuanAfiliado;
                        newFicha.primerApellidoFuanAfiliado = fichaAfiliado.primerApellidoFuanAfiliado;
                        newFicha.segundoApellidoFuanAfiliado = fichaAfiliado.segundoApellidoFuanAfiliado;
                        newFicha.nombreCompletoAfiliado = ((fichaAfiliado.primerNombreFuanAfiliado != null) ? fichaAfiliado.primerNombreFuanAfiliado : "") + " " +
                                                          ((fichaAfiliado.segundoNombreFuanAfiliado != null) ? fichaAfiliado.segundoNombreFuanAfiliado : "") + " " +
                                                          ((fichaAfiliado.primerApellidoFuanAfiliado != null) ? fichaAfiliado.primerApellidoFuanAfiliado : "") + " " +
                                                          ((fichaAfiliado.segundoApellidoFuanAfiliado != null) ? fichaAfiliado.segundoApellidoFuanAfiliado : "");

                        newFicha.codigoTipoIdentificacion = fichaAfiliado.codigoTipoIdentificacion;
                        newFicha.identificacionFuanAfiliado = fichaAfiliado.identificacionFuanAfiliado;
                        newFicha.numCarnetFuanAfiliado = fichaAfiliado.numCarnetFuanAfiliado;
                        newFicha.fechaNacimientoFuanAfiliado = fichaAfiliado.fechaNacimientoFuanAfiliado;
                        newFicha.nombreDepartamento = fichaAfiliado.nombreDepartamento;
                        newFicha.nombreCiudad = fichaAfiliado.nombreCiudad;
                        newFicha.direccion = fichaAfiliado.direccionFuanAfiliado;
                        newFicha.telefono = fichaAfiliado.telefonoFuanAfiliado;
                        newFicha.celular = fichaAfiliado.celularFuanAfiliado;
                        newFicha.ipsPrimaria = "";
                        newFicha.edad = (DateTime.Today.AddTicks(-fichaAfiliado.fechaNacimientoFuanAfiliado.Ticks).Year - 1).ToString();
                        newFicha.sisben = fichaAfiliado.puntajeSisbenFuanAfiliado.ToString();
                        newFicha.raza = fichaAfiliado.razaIfppir;
                        newFicha.escolaridad = fichaAfiliado.escolaridadIfppir;
                        newFicha.zonaRural = (fichaAfiliado.nombreTipoZona == "Rural") ? "X" : "";
                        newFicha.zonaUrbana = (fichaAfiliado.nombreTipoZona == "Urbana") ? "X" : "";
                        newFicha.sexoFemenino = (fichaAfiliado.codigoTipoSexo == "F") ? "X" : "";
                        newFicha.sexoMasculino = (fichaAfiliado.codigoTipoSexo == "M") ? "X" : "";
                        newFicha.familiarCercado = fichaAfiliado.familiarCercanoIfppir;
                        newFicha.familiarTelefono = fichaAfiliado.telefonoFamiliarIfppir;
                        newFicha.gestanteSi = (fichaAfiliado.gestanteIfppir == true) ? "X" : "";
                        newFicha.gestanteNo = (fichaAfiliado.gestanteIfppir == false) ? "X" : "";
                        newFicha.fur = Convert.ToDateTime(fichaAfiliado.furIfppir).ToShortDateString();
                        newFicha.fpp = Convert.ToDateTime(fichaAfiliado.fppIfppir).ToShortDateString();
                        newFicha.colesterolTotal = fichaAfiliado.colesterolTotalIfppir;
                        newFicha.colesterolLDL = fichaAfiliado.colesterolLdlIfppir;
                        newFicha.colesterolHDL = fichaAfiliado.colesterolHdlIfppir;
                        newFicha.glicemia = fichaAfiliado.glicemiaIfppir;
                        newFicha.gIfppir = fichaAfiliado.gIfppir;
                        newFicha.pIfppir = fichaAfiliado.pIfppir;
                        newFicha.cIfppir = fichaAfiliado.cIfppir;
                        newFicha.aIfppir = fichaAfiliado.aIfppir;
                        newFicha.fechaAplicacion = fichaAfiliado.fechaAplicacionIfppir.ToShortDateString();
                        newFicha.peso = fichaAfiliado.pesoIfppir.ToString();
                        newFicha.tallaIfppir = fichaAfiliado.tallaIfppir.ToString();
                        newFicha.imc = fichaAfiliado.masaCorporalIfppir.ToString();
                        newFicha.perimetroAbdominal = fichaAfiliado.perimetroAbdominalIfppir.ToString();
                        var sisto = (fichaAfiliado.sistolicaIfppir != null) ? fichaAfiliado.sistolicaIfppir.ToString() : "";
                        var diasto = (fichaAfiliado.diastolicaIfppir != null) ? fichaAfiliado.diastolicaIfppir.ToString() : "";
                        newFicha.tensionArterial = sisto + "/" + diasto;
                        newFicha.observaciones = fichaAfiliado.observacionIfppir;
                        newFicha.firmaFicha = fichaAfiliado.firmaIfppir;
                        newFicha.pregunta1No = "NA";
                        newFicha.pregunta2No = "NA";
                        newFicha.pregunta5No = "NA";
                        newFicha.pregunta8No = "NA";
                        newFicha.pregunta9No = "NA";
                        newFicha.pregunta11No = "NA";
                        newFicha.pregunta12No = "NA";
                        newFicha.pregunta13No = "NA";
                        newFicha.pregunta14No = "NA";
                        newFicha.pregunta15No = "NA";
                        newFicha.pregunta16No = "NA";
                        newFicha.pregunta17No = "NA";
                        newFicha.pregunta18No = "NA";
                        newFicha.pregunta19No = "NA";
                        newFicha.pregunta20No = "NA";
                        newFicha.pregunta21No = "NA";
                        newFicha.pregunta22No = "NA";
                        newFicha.pregunta23No = "NA";
                        newFicha.pregunta24No = "NA";
                        newFicha.pregunta25No = "NA";
                        newFicha.pregunta26No = "NA";
                        newFicha.pregunta27No = "NA";
                        newFicha.pregunta28No = "NA";
                        newFicha.pregunta29No = "NA";
                        newFicha.pregunta30No = "NA";
                        newFicha.pregunta31No = "NA";
                        newFicha.pregunta32No = "NA";
                        newFicha.pregunta33No = "NA";
                        newFicha.pregunta34No = "NA";
                        newFicha.pregunta35No = "NA";
                        newFicha.pregunta36No = "NA";
                        newFicha.pregunta37No = "NA";
                        newFicha.pregunta38No = "NA";
                        newFicha.pregunta39No = "NA";
                        newFicha.pregunta41No = "NA";
                        newFicha.pregunta43No = "NA";
                        newFicha.pregunta44No = "NA";
                        newFicha.pregunta46No = "NA";
                        newFicha.pregunta47No = "NA";
                        newFicha.pregunta48No = "NA";
                        newFicha.pregunta49No = "NA";
                        newFicha.pregunta50No = "NA";
                        newFicha.pregunta51No = "NA";
                        newFicha.pregunta52No = "NA";
                        newFicha.pregunta53No = "NA";
                        newFicha.pregunta54No = "NA";
                        newFicha.pregunta55No = "NA";
                        newFicha.pregunta56No = "NA";
                        newFicha.pregunta57No = "NA";
                        newFicha.pregunta58No = "NA";

                        newFicha.pregunta59No = "NA";
                        newFicha.pregunta60No = "NA";
                        newFicha.pregunta61No = "NA";
                        newFicha.pregunta62No = "NA";
                        newFicha.pregunta63No = "NA";
                        newFicha.pregunta64No = "NA";
                        newFicha.pregunta65No = "NA";
                        newFicha.pregunta66No = "NA";
                        newFicha.pregunta67No = "NA";
                        newFicha.pregunta68No = "NA";
                        newFicha.pregunta69No = "NA";
                        newFicha.pregunta70No = "NA";
                        newFicha.pregunta71No = "NA";
                        newFicha.pregunta72No = "NA";
                        newFicha.pregunta73No = "NA";
                        newFicha.pregunta74No = "NA";
                        newFicha.pregunta75No = "NA";
                        newFicha.pregunta76No = "NA";
                        newFicha.pregunta77No = "NA";
                        newFicha.pregunta78No = "NA";
                        newFicha.pregunta79No = "NA";
                        newFicha.pregunta80No = "NA";
                        newFicha.pregunta81No = "NA";
                        newFicha.pregunta82No = "NA";
                        newFicha.pregunta83No = "NA";
                        newFicha.pregunta84No = "NA";
                        newFicha.pregunta85No = "NA";
                        newFicha.pregunta86No = "NA";
                        newFicha.pregunta87No = "NA";
                        newFicha.pregunta88No = "NA";
                        newFicha.pregunta89No = "NA";
                        newFicha.pregunta90No = "NA";
                        newFicha.pregunta91No = "NA";
                        newFicha.pregunta92No = "NA";
                        newFicha.pregunta93No = "NA";
                        newFicha.pregunta94No = "NA";
                        newFicha.pregunta95No = "NA";
                        newFicha.pregunta96No = "NA";
                        newFicha.pregunta97No = "NA";
                        newFicha.pregunta98No = "NA";
                        newFicha.pregunta99No = "NA";
                        newFicha.pregunta100No = "NA";
                        newFicha.pregunta101No = "NA";
                        newFicha.pregunta102No = "NA";
                        newFicha.pregunta103No = "NA";
                        newFicha.pregunta104No = "NA";
                        newFicha.pregunta105No = "NA";
                        newFicha.pregunta106No = "NA";
                        newFicha.pregunta107No = "NA";
                        newFicha.pregunta108No = "NA";

                        newFicha.pregunta109No = "NA";
                        newFicha.pregunta110No = "NA";
                        newFicha.pregunta111No = "NA";
                        newFicha.pregunta112No = "NA";
                        newFicha.pregunta113No = "NA";
                        newFicha.pregunta114No = "NA";
                        newFicha.pregunta115No = "NA";
                        newFicha.pregunta116No = "NA";
                        newFicha.pregunta117No = "NA";
                        newFicha.pregunta118No = "NA";
                        newFicha.pregunta119No = "NA";
                        newFicha.pregunta120No = "NA";
                        newFicha.pregunta121No = "NA";
                        newFicha.pregunta122No = "NA";
                        newFicha.pregunta123No = "NA";
                        newFicha.pregunta124No = "NA";
                        newFicha.pregunta125No = "NA";
                        newFicha.pregunta126No = "NA";
                        newFicha.pregunta127No = "NA";
                        newFicha.pregunta128No = "NA";
                        newFicha.pregunta129No = "NA";
                        newFicha.pregunta130No = "NA";
                        newFicha.pregunta131No = "NA";
                        newFicha.pregunta132No = "NA";
                        newFicha.pregunta133No = "NA";
                        newFicha.pregunta134No = "NA";
                        newFicha.pregunta135No = "NA";
                        newFicha.pregunta136No = "NA";
                        newFicha.pregunta137No = "NA";
                        newFicha.pregunta138No = "NA";
                        newFicha.pregunta139No = "NA";
                        newFicha.pregunta140No = "NA";
                        newFicha.pregunta141No = "NA";
                        newFicha.pregunta142No = "NA";
                        newFicha.pregunta143No = "NA";
                        newFicha.pregunta144No = "NA";
                        newFicha.pregunta145No = "NA";
                        newFicha.pregunta146No = "NA";
                        newFicha.pregunta147No = "NA";
                        newFicha.pregunta148No = "NA";
                        newFicha.pregunta149No = "NA";
                        newFicha.pregunta150No = "NA";
                        newFicha.pregunta151No = "NA";
                        newFicha.pregunta152No = "NA";
                        newFicha.pregunta153No = "NA";
                        newFicha.pregunta154No = "NA";
                        newFicha.pregunta155No = "NA";
                        newFicha.pregunta156No = "NA";
                        newFicha.pregunta157No = "NA";
                        newFicha.pregunta158No = "NA";
                        newFicha.pregunta159No = "NA";
                        newFicha.pregunta160No = "NA";
                        newFicha.pregunta161No = "NA";
                        newFicha.pregunta162No = "NA";
                        newFicha.pregunta163No = "NA";
                        newFicha.pregunta164No = "NA";
                        newFicha.pregunta165No = "NA";
                        newFicha.pregunta166No = "NA";
                        newFicha.pregunta167No = "NA";
                        newFicha.pregunta168No = "NA";
                        newFicha.pregunta169No = "NA";

                        newFicha.pregunta1Si = "NA";
                        newFicha.pregunta2Si = "NA";
                        newFicha.pregunta5Si = "NA";
                        newFicha.pregunta8Si = "NA";
                        newFicha.pregunta9Si = "NA";
                        newFicha.pregunta11Si = "NA";
                        newFicha.pregunta12Si = "NA";
                        newFicha.pregunta13Si = "NA";
                        newFicha.pregunta14Si = "NA";
                        newFicha.pregunta15Si = "NA";
                        newFicha.pregunta16Si = "NA";
                        newFicha.pregunta17Si = "NA";
                        newFicha.pregunta18Si = "NA";
                        newFicha.pregunta19Si = "NA";
                        newFicha.pregunta20Si = "NA";
                        newFicha.pregunta21Si = "NA";
                        newFicha.pregunta22Si = "NA";
                        newFicha.pregunta23Si = "NA";
                        newFicha.pregunta24Si = "NA";
                        newFicha.pregunta25Si = "NA";
                        newFicha.pregunta26Si = "NA";
                        newFicha.pregunta27Si = "NA";
                        newFicha.pregunta28Si = "NA";
                        newFicha.pregunta29Si = "NA";
                        newFicha.pregunta30Si = "NA";
                        newFicha.pregunta31Si = "NA";
                        newFicha.pregunta32Si = "NA";
                        newFicha.pregunta33Si = "NA";
                        newFicha.pregunta34Si = "NA";
                        newFicha.pregunta35Si = "NA";
                        newFicha.pregunta36Si = "NA";
                        newFicha.pregunta37Si = "NA";
                        newFicha.pregunta38Si = "NA";
                        newFicha.pregunta39Si = "NA";
                        newFicha.pregunta41Si = "NA";
                        newFicha.pregunta43Si = "NA";
                        newFicha.pregunta44Si = "NA";
                        newFicha.pregunta46Si = "NA";
                        newFicha.pregunta47Si = "NA";
                        newFicha.pregunta48Si = "NA";
                        newFicha.pregunta49Si = "NA";
                        newFicha.pregunta50Si = "NA";
                        newFicha.pregunta51Si = "NA";
                        newFicha.pregunta52Si = "NA";
                        newFicha.pregunta53Si = "NA";
                        newFicha.pregunta54Si = "NA";
                        newFicha.pregunta55Si = "NA";
                        newFicha.pregunta56Si = "NA";
                        newFicha.pregunta57Si = "NA";
                        newFicha.pregunta58Si = "NA";

                        newFicha.pregunta59Si = "NA";
                        newFicha.pregunta60Si = "NA";
                        newFicha.pregunta61Si = "NA";
                        newFicha.pregunta62Si = "NA";
                        newFicha.pregunta63Si = "NA";
                        newFicha.pregunta64Si = "NA";
                        newFicha.pregunta65Si = "NA";
                        newFicha.pregunta66Si = "NA";
                        newFicha.pregunta67Si = "NA";
                        newFicha.pregunta68Si = "NA";
                        newFicha.pregunta69Si = "NA";
                        newFicha.pregunta70Si = "NA";
                        newFicha.pregunta71Si = "NA";
                        newFicha.pregunta72Si = "NA";
                        newFicha.pregunta73Si = "NA";
                        newFicha.pregunta74Si = "NA";
                        newFicha.pregunta75Si = "NA";
                        newFicha.pregunta76Si = "NA";
                        newFicha.pregunta77Si = "NA";
                        newFicha.pregunta78Si = "NA";
                        newFicha.pregunta79Si = "NA";
                        newFicha.pregunta80Si = "NA";
                        newFicha.pregunta81Si = "NA";
                        newFicha.pregunta82Si = "NA";
                        newFicha.pregunta83Si = "NA";
                        newFicha.pregunta84Si = "NA";
                        newFicha.pregunta85Si = "NA";
                        newFicha.pregunta86Si = "NA";
                        newFicha.pregunta87Si = "NA";
                        newFicha.pregunta88Si = "NA";
                        newFicha.pregunta89Si = "NA";
                        newFicha.pregunta90Si = "NA";
                        newFicha.pregunta91Si = "NA";
                        newFicha.pregunta92Si = "NA";
                        newFicha.pregunta93Si = "NA";
                        newFicha.pregunta94Si = "NA";
                        newFicha.pregunta95Si = "NA";
                        newFicha.pregunta96Si = "NA";
                        newFicha.pregunta97Si = "NA";
                        newFicha.pregunta98Si = "NA";
                        newFicha.pregunta99Si = "NA";
                        newFicha.pregunta100Si = "NA";
                        newFicha.pregunta101Si = "NA";
                        newFicha.pregunta102Si = "NA";
                        newFicha.pregunta103Si = "NA";
                        newFicha.pregunta104Si = "NA";
                        newFicha.pregunta105Si = "NA";
                        newFicha.pregunta106Si = "NA";
                        newFicha.pregunta107Si = "NA";
                        newFicha.pregunta108Si = "NA";

                        newFicha.pregunta109Si = "NA";
                        newFicha.pregunta110Si = "NA";
                        newFicha.pregunta111Si = "NA";
                        newFicha.pregunta112Si = "NA";
                        newFicha.pregunta113Si = "NA";
                        newFicha.pregunta114Si = "NA";
                        newFicha.pregunta115Si = "NA";
                        newFicha.pregunta116Si = "NA";
                        newFicha.pregunta117Si = "NA";
                        newFicha.pregunta118Si = "NA";
                        newFicha.pregunta119Si = "NA";
                        newFicha.pregunta120Si = "NA";
                        newFicha.pregunta121Si = "NA";
                        newFicha.pregunta122Si = "NA";
                        newFicha.pregunta123Si = "NA";
                        newFicha.pregunta124Si = "NA";
                        newFicha.pregunta125Si = "NA";
                        newFicha.pregunta126Si = "NA";
                        newFicha.pregunta127Si = "NA";
                        newFicha.pregunta128Si = "NA";
                        newFicha.pregunta129Si = "NA";
                        newFicha.pregunta130Si = "NA";
                        newFicha.pregunta131Si = "NA";
                        newFicha.pregunta132Si = "NA";
                        newFicha.pregunta133Si = "NA";
                        newFicha.pregunta134Si = "NA";
                        newFicha.pregunta135Si = "NA";
                        newFicha.pregunta136Si = "NA";
                        newFicha.pregunta137Si = "NA";
                        newFicha.pregunta138Si = "NA";
                        newFicha.pregunta139Si = "NA";
                        newFicha.pregunta140Si = "NA";
                        newFicha.pregunta141Si = "NA";
                        newFicha.pregunta142Si = "NA";
                        newFicha.pregunta143Si = "NA";
                        newFicha.pregunta144Si = "NA";
                        newFicha.pregunta145Si = "NA";
                        newFicha.pregunta146Si = "NA";
                        newFicha.pregunta147Si = "NA";
                        newFicha.pregunta148Si = "NA";
                        newFicha.pregunta149Si = "NA";
                        newFicha.pregunta150Si = "NA";
                        newFicha.pregunta151Si = "NA";
                        newFicha.pregunta152Si = "NA";
                        newFicha.pregunta153Si = "NA";
                        newFicha.pregunta154Si = "NA";
                        newFicha.pregunta155Si = "NA";
                        newFicha.pregunta156Si = "NA";
                        newFicha.pregunta157Si = "NA";
                        newFicha.pregunta158Si = "NA";
                        newFicha.pregunta159Si = "NA";
                        newFicha.pregunta160Si = "NA";
                        newFicha.pregunta161Si = "NA";
                        newFicha.pregunta162Si = "NA";
                        newFicha.pregunta163Si = "NA";
                        newFicha.pregunta164Si = "NA";
                        newFicha.pregunta165Si = "NA";
                        newFicha.pregunta166Si = "NA";
                        newFicha.pregunta167Si = "NA";
                        newFicha.pregunta168Si = "NA";
                        newFicha.pregunta169Si = "NA";
                        fichaAfiliado.preguntas.ForEach(p =>
                        {
                            switch (p.codigoPreguntasSubFactorRiesgo)
                            {
                                case "1":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta1Si = "X";
                                        newFicha.pregunta1No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta1No = "X";
                                        newFicha.pregunta1Si = "";
                                    }
                                    break;
                                case "(2-4)":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta2Si = "X";
                                        newFicha.pregunta2No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta2No = "X";
                                        newFicha.pregunta2Si = "";
                                    }
                                    break;
                                case "(5-7)":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta5Si = "X";
                                        newFicha.pregunta5No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta5No = "X";
                                        newFicha.pregunta5Si = "";
                                    }
                                    break;
                                case "8":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta8Si = "X";
                                        newFicha.pregunta8No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta8No = "X";
                                        newFicha.pregunta8Si = "";
                                    }
                                    break;
                                case "(9-10)":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta9Si = "X";
                                        newFicha.pregunta9No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta9No = "X";
                                        newFicha.pregunta9Si = "";
                                    }
                                    break;
                                case "11":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta11Si = "X";
                                        newFicha.pregunta11No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta11No = "X";
                                        newFicha.pregunta11Si = "";
                                    }
                                    break;
                                case "12":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta12Si = "X";
                                        newFicha.pregunta12No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta12No = "X";
                                        newFicha.pregunta12Si = "";
                                    }
                                    break;
                                case "13":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta13Si = "X";
                                        newFicha.pregunta13No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta13No = "X";
                                        newFicha.pregunta13Si = "";
                                    }
                                    break;
                                case "14":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta14Si = "X";
                                        newFicha.pregunta14No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta14No = "X";
                                        newFicha.pregunta14Si = "";
                                    }
                                    break;
                                case "15":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta15Si = "X";
                                        newFicha.pregunta15No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta15No = "X";
                                        newFicha.pregunta15Si = "";
                                    }
                                    break;
                                case "16":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta16Si = "X";
                                        newFicha.pregunta16No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta16No = "X";
                                        newFicha.pregunta16Si = "";
                                    }
                                    break;
                                case "17":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta17Si = "X";
                                        newFicha.pregunta17No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta17No = "X";
                                        newFicha.pregunta17Si = "";
                                    }
                                    break;
                                case "18":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta18Si = "X";
                                        newFicha.pregunta18No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta18No = "X";
                                        newFicha.pregunta18Si = "";
                                    }
                                    break;
                                case "19":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta19Si = "X";
                                        newFicha.pregunta19No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta19No = "X";
                                        newFicha.pregunta19Si = "";
                                    }
                                    break;
                                case "20":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta20Si = "X";
                                        newFicha.pregunta20No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta20No = "X";
                                        newFicha.pregunta20Si = "";
                                    }
                                    break;
                                case "21":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta21Si = "X";
                                        newFicha.pregunta21No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta21No = "X";
                                        newFicha.pregunta21Si = "";
                                    }
                                    break;
                                case "22":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta22Si = "X";
                                        newFicha.pregunta22No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta22No = "X";
                                        newFicha.pregunta22Si = "";
                                    }
                                    break;
                                case "23":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta23Si = "X";
                                        newFicha.pregunta23No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta23No = "X";
                                        newFicha.pregunta23Si = "";
                                    }
                                    break;
                                case "24":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta24Si = "X";
                                        newFicha.pregunta24No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta24No = "X";
                                        newFicha.pregunta24Si = "";
                                    }
                                    break;
                                case "25":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta25Si = "X";
                                        newFicha.pregunta25No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta25No = "X";
                                        newFicha.pregunta25Si = "";
                                    }
                                    break;
                                case "26":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta26Si = "X";
                                        newFicha.pregunta26No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta26No = "X";
                                        newFicha.pregunta26Si = "";
                                    }
                                    break;
                                case "27":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta27Si = "X";
                                        newFicha.pregunta27No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta27No = "X";
                                        newFicha.pregunta27Si = "";
                                    }
                                    break;
                                case "28":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta28Si = "X";
                                        newFicha.pregunta28No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta28No = "X";
                                        newFicha.pregunta28Si = "";
                                    }
                                    break;
                                case "29":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta29Si = "X";
                                        newFicha.pregunta29No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta29No = "X";
                                        newFicha.pregunta29Si = "";
                                    }
                                    break;
                                case "30":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta30Si = "X";
                                        newFicha.pregunta30No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta30No = "X";
                                        newFicha.pregunta30Si = "";
                                    }
                                    break;
                                case "31":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta31Si = "X";
                                        newFicha.pregunta31No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta31No = "X";
                                        newFicha.pregunta31Si = "";
                                    }
                                    break;
                                case "32":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta32Si = "X";
                                        newFicha.pregunta32No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta32No = "X";
                                        newFicha.pregunta32Si = "";
                                    }
                                    break;
                                case "33":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta33Si = "X";
                                        newFicha.pregunta33No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta33No = "X";
                                        newFicha.pregunta33Si = "";
                                    }
                                    break;
                                case "34":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta34Si = "X";
                                        newFicha.pregunta34No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta34No = "X";
                                        newFicha.pregunta34Si = "";
                                    }
                                    break;
                                case "35":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta35Si = "X";
                                        newFicha.pregunta35No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta35No = "X";
                                        newFicha.pregunta35Si = "";
                                    }
                                    break;
                                case "36":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta36Si = "X";
                                        newFicha.pregunta36No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta36No = "X";
                                        newFicha.pregunta36Si = "";
                                    }
                                    break;
                                case "37":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta37Si = "X";
                                        newFicha.pregunta37No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta37No = "X";
                                        newFicha.pregunta37Si = "";
                                    }
                                    break;
                                case "38":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta38Si = "X";
                                        newFicha.pregunta38No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta38No = "X";
                                        newFicha.pregunta38Si = "";
                                    }
                                    break;
                                case "(39-40)":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta39Si = "X";
                                        newFicha.pregunta39No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta39No = "X";
                                        newFicha.pregunta39Si = "";
                                    }
                                    break;
                                case "(41-42)":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta41Si = "X";
                                        newFicha.pregunta41No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta41No = "X";
                                        newFicha.pregunta41Si = "";
                                    }
                                    break;
                                case "43":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta43Si = "X";
                                        newFicha.pregunta43No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta43No = "X";
                                        newFicha.pregunta43Si = "";
                                    }
                                    break;
                                case "(44-45)":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta44Si = "X";
                                        newFicha.pregunta44No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta44No = "X";
                                        newFicha.pregunta44Si = "";
                                    }
                                    break;
                                case "46":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta46Si = "X";
                                        newFicha.pregunta46No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta46No = "X";
                                        newFicha.pregunta46Si = "";
                                    }
                                    break;
                                case "47":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta47Si = "X";
                                        newFicha.pregunta47No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta47No = "X";
                                        newFicha.pregunta47Si = "";
                                    }
                                    break;
                                case "48":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta48Si = "X";
                                        newFicha.pregunta48No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta48No = "X";
                                        newFicha.pregunta48Si = "";
                                    }
                                    break;
                                case "49":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta49Si = "X";
                                        newFicha.pregunta49No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta49No = "X";
                                        newFicha.pregunta49Si = "";
                                    }
                                    break;
                                case "50":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta50Si = "X";
                                        newFicha.pregunta50No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta50No = "X";
                                        newFicha.pregunta50Si = "";
                                    }
                                    break;
                                case "51":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta51Si = "X";
                                        newFicha.pregunta51No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta51No = "X";
                                        newFicha.pregunta51Si = "";
                                    }
                                    break;
                                case "52":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta52Si = "X";
                                        newFicha.pregunta52No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta52No = "X";
                                        newFicha.pregunta52Si = "";
                                    }
                                    break;
                                case "53":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta53Si = "X";
                                        newFicha.pregunta53No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta53No = "X";
                                        newFicha.pregunta53Si = "";
                                    }
                                    break;
                                case "54":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta54Si = "X";
                                        newFicha.pregunta54No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta54No = "X";
                                        newFicha.pregunta54Si = "";
                                    }
                                    break;
                                case "55":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta55Si = "X";
                                        newFicha.pregunta55No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta55No = "X";
                                        newFicha.pregunta55Si = "";
                                    }
                                    break;
                                case "56":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta56Si = "X";
                                        newFicha.pregunta56No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta56No = "X";
                                        newFicha.pregunta56Si = "";
                                    }
                                    break;
                                case "57":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta57Si = "X";
                                        newFicha.pregunta57No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta57No = "X";
                                        newFicha.pregunta57Si = "";
                                    }
                                    break;
                                case "58":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta58Si = "X";
                                        newFicha.pregunta58No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta58No = "X";
                                        newFicha.pregunta58Si = "";
                                    }
                                    break;
                                case "59":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta59Si = "X";
                                        newFicha.pregunta59No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta59No = "X";
                                        newFicha.pregunta59Si = "";
                                    }
                                    break;
                                case "60":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta60Si = "X";
                                        newFicha.pregunta60No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta60No = "X";
                                        newFicha.pregunta60Si = "";
                                    }
                                    break;
                                case "61":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta61Si = "X";
                                        newFicha.pregunta61No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta61No = "X";
                                        newFicha.pregunta61Si = "";
                                    }
                                    break;
                                case "62":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta62Si = "X";
                                        newFicha.pregunta62No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta62No = "X";
                                        newFicha.pregunta62Si = "";
                                    }
                                    break;
                                case "63":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta63Si = "X";
                                        newFicha.pregunta63No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta63No = "X";
                                        newFicha.pregunta63Si = "";
                                    }
                                    break;
                                case "64":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta64Si = "X";
                                        newFicha.pregunta64No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta64No = "X";
                                        newFicha.pregunta64Si = "";
                                    }
                                    break;
                                case "65":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta65Si = "X";
                                        newFicha.pregunta65No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta65No = "X";
                                        newFicha.pregunta65Si = "";
                                    }
                                    break;
                                case "66":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta66Si = "X";
                                        newFicha.pregunta66No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta66No = "X";
                                        newFicha.pregunta66Si = "";
                                    }
                                    break;
                                case "67":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta67Si = "X";
                                        newFicha.pregunta67No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta67No = "X";
                                        newFicha.pregunta67Si = "";
                                    }
                                    break;
                                case "68":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta68Si = "X";
                                        newFicha.pregunta68No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta68No = "X";
                                        newFicha.pregunta68Si = "";
                                    }
                                    break;
                                case "69":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta69Si = "X";
                                        newFicha.pregunta69No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta69No = "X";
                                        newFicha.pregunta69Si = "";
                                    }
                                    break;
                                case "70":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta70Si = "X";
                                        newFicha.pregunta70No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta70No = "X";
                                        newFicha.pregunta70Si = "";
                                    }
                                    break;
                                case "71":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta71Si = "X";
                                        newFicha.pregunta71No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta71No = "X";
                                        newFicha.pregunta71Si = "";
                                    }
                                    break;
                                case "72":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta72Si = "X";
                                        newFicha.pregunta72No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta72No = "X";
                                        newFicha.pregunta72Si = "";
                                    }
                                    break;
                                case "73":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta73Si = "X";
                                        newFicha.pregunta73No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta73No = "X";
                                        newFicha.pregunta73Si = "";
                                    }
                                    break;
                                case "74":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta74Si = "X";
                                        newFicha.pregunta74No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta74No = "X";
                                        newFicha.pregunta74Si = "";
                                    }
                                    break;
                                case "75":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta75Si = "X";
                                        newFicha.pregunta75No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta75No = "X";
                                        newFicha.pregunta75Si = "";
                                    }
                                    break;
                                case "76":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta76Si = "X";
                                        newFicha.pregunta76No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta76No = "X";
                                        newFicha.pregunta76Si = "";
                                    }
                                    break;
                                case "77":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta77Si = "X";
                                        newFicha.pregunta77No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta77No = "X";
                                        newFicha.pregunta77Si = "";
                                    }
                                    break;
                                case "78":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta78Si = "X";
                                        newFicha.pregunta78No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta78No = "X";
                                        newFicha.pregunta78Si = "";
                                    }
                                    break;
                                case "79":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta79Si = "X";
                                        newFicha.pregunta79No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta79No = "X";
                                        newFicha.pregunta79Si = "";
                                    }
                                    break;
                                case "80":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta80Si = "X";
                                        newFicha.pregunta80No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta80No = "X";
                                        newFicha.pregunta80Si = "";
                                    }
                                    break;
                                case "81":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta81Si = "X";
                                        newFicha.pregunta81No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta81No = "X";
                                        newFicha.pregunta81Si = "";
                                    }
                                    break;
                                case "82":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta82Si = "X";
                                        newFicha.pregunta82No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta82No = "X";
                                        newFicha.pregunta82Si = "";
                                    }
                                    break;
                                case "83":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta83Si = "X";
                                        newFicha.pregunta83No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta83No = "X";
                                        newFicha.pregunta83Si = "";
                                    }
                                    break;
                                case "84":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta84Si = "X";
                                        newFicha.pregunta84No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta84No = "X";
                                        newFicha.pregunta84Si = "";
                                    }
                                    break;
                                case "85":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta85Si = "X";
                                        newFicha.pregunta85No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta85No = "X";
                                        newFicha.pregunta85Si = "";
                                    }
                                    break;
                                case "86":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta86Si = "X";
                                        newFicha.pregunta86No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta86No = "X";
                                        newFicha.pregunta86Si = "";
                                    }
                                    break;
                                case "87":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta87Si = "X";
                                        newFicha.pregunta87No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta87No = "X";
                                        newFicha.pregunta87Si = "";
                                    }
                                    break;
                                case "88":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta88Si = "X";
                                        newFicha.pregunta88No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta88No = "X";
                                        newFicha.pregunta88Si = "";
                                    }
                                    break;
                                case "89":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta89Si = "X";
                                        newFicha.pregunta89No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta89No = "X";
                                        newFicha.pregunta89Si = "";
                                    }
                                    break;
                                case "90":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta90Si = "X";
                                        newFicha.pregunta90No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta90No = "X";
                                        newFicha.pregunta90Si = "";
                                    }
                                    break;
                                case "91":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta91Si = "X";
                                        newFicha.pregunta91No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta91No = "X";
                                        newFicha.pregunta91Si = "";
                                    }
                                    break;
                                case "92":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta92Si = "X";
                                        newFicha.pregunta92No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta92No = "X";
                                        newFicha.pregunta92Si = "";
                                    }
                                    break;
                                case "93":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta93Si = "X";
                                        newFicha.pregunta93No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta93No = "X";
                                        newFicha.pregunta93Si = "";
                                    }
                                    break;
                                case "94":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta94Si = "X";
                                        newFicha.pregunta94No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta94No = "X";
                                        newFicha.pregunta94Si = "";
                                    }
                                    break;
                                case "95":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta95Si = "X";
                                        newFicha.pregunta95No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta95No = "X";
                                        newFicha.pregunta95Si = "";
                                    }
                                    break;
                                case "96":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta96Si = "X";
                                        newFicha.pregunta96No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta96No = "X";
                                        newFicha.pregunta96Si = "";
                                    }
                                    break;
                                case "97":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta97Si = "X";
                                        newFicha.pregunta97No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta97No = "X";
                                        newFicha.pregunta97Si = "";
                                    }
                                    break;
                                case "98":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta98Si = "X";
                                        newFicha.pregunta98No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta98No = "X";
                                        newFicha.pregunta98Si = "";
                                    }
                                    break;
                                case "99":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta99Si = "X";
                                        newFicha.pregunta99No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta99No = "X";
                                        newFicha.pregunta99Si = "";
                                    }
                                    break;
                                case "100":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta100Si = "X";
                                        newFicha.pregunta100No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta100No = "X";
                                        newFicha.pregunta100Si = "";
                                    }
                                    break;
                                case "101":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta101Si = "X";
                                        newFicha.pregunta101No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta101No = "X";
                                        newFicha.pregunta101Si = "";
                                    }
                                    break;
                                case "102":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta102Si = "X";
                                        newFicha.pregunta102No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta102No = "X";
                                        newFicha.pregunta102Si = "";
                                    }
                                    break;
                                case "103":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta103Si = "X";
                                        newFicha.pregunta103No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta103No = "X";
                                        newFicha.pregunta103Si = "";
                                    }
                                    break;
                                case "104":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta104Si = "X";
                                        newFicha.pregunta104No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta104No = "X";
                                        newFicha.pregunta104Si = "";
                                    }
                                    break;
                                case "105":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta105Si = "X";
                                        newFicha.pregunta105No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta105No = "X";
                                        newFicha.pregunta105Si = "";
                                    }
                                    break;
                                case "106":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta106Si = "X";
                                        newFicha.pregunta106No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta106No = "X";
                                        newFicha.pregunta106Si = "";
                                    }
                                    break;
                                case "107":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta107Si = "X";
                                        newFicha.pregunta107No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta107No = "X";
                                        newFicha.pregunta107Si = "";
                                    }
                                    break;
                                case "108":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta108Si = "X";
                                        newFicha.pregunta108No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta108No = "X";
                                        newFicha.pregunta108Si = "";
                                    }
                                    break;
                                case "109":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta109Si = "X";
                                        newFicha.pregunta109No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta109No = "X";
                                        newFicha.pregunta109Si = "";
                                    }
                                    break;
                                case "110":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta110Si = "X";
                                        newFicha.pregunta110No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta110No = "X";
                                        newFicha.pregunta110Si = "";
                                    }
                                    break;
                                case "111":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta111Si = "X";
                                        newFicha.pregunta111No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta111No = "X";
                                        newFicha.pregunta111Si = "";
                                    }
                                    break;
                                case "112":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta112Si = "X";
                                        newFicha.pregunta112No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta112No = "X";
                                        newFicha.pregunta112Si = "";
                                    }
                                    break;
                                case "113":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta113Si = "X";
                                        newFicha.pregunta113No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta113No = "X";
                                        newFicha.pregunta113Si = "";
                                    }
                                    break;
                                case "114":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta114Si = "X";
                                        newFicha.pregunta114No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta114No = "X";
                                        newFicha.pregunta114Si = "";
                                    }
                                    break;
                                case "115":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta115Si = "X";
                                        newFicha.pregunta115No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta115No = "X";
                                        newFicha.pregunta115Si = "";
                                    }
                                    break;
                                case "116":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta116Si = "X";
                                        newFicha.pregunta116No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta116No = "X";
                                        newFicha.pregunta116Si = "";
                                    }
                                    break;
                                case "117":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta117Si = "X";
                                        newFicha.pregunta117No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta117No = "X";
                                        newFicha.pregunta117Si = "";
                                    }
                                    break;
                                case "118":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta118Si = "X";
                                        newFicha.pregunta118No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta118No = "X";
                                        newFicha.pregunta118Si = "";
                                    }
                                    break;
                                case "119":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta119Si = "X";
                                        newFicha.pregunta119No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta119No = "X";
                                        newFicha.pregunta119Si = "";
                                    }
                                    break;
                                case "120":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta120Si = "X";
                                        newFicha.pregunta120No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta120No = "X";
                                        newFicha.pregunta120Si = "";
                                    }
                                    break;
                                case "121":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta121Si = "X";
                                        newFicha.pregunta121No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta121No = "X";
                                        newFicha.pregunta121Si = "";
                                    }
                                    break;
                                case "122":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta122Si = "X";
                                        newFicha.pregunta122No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta122No = "X";
                                        newFicha.pregunta122Si = "";
                                    }
                                    break;
                                case "123":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta123Si = "X";
                                        newFicha.pregunta123No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta123No = "X";
                                        newFicha.pregunta123Si = "";
                                    }
                                    break;
                                case "124":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta124Si = "X";
                                        newFicha.pregunta124No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta124No = "X";
                                        newFicha.pregunta124Si = "";
                                    }
                                    break;
                                case "125":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta125Si = "X";
                                        newFicha.pregunta125No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta125No = "X";
                                        newFicha.pregunta125Si = "";
                                    }
                                    break;
                                case "126":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta126Si = "X";
                                        newFicha.pregunta126No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta126No = "X";
                                        newFicha.pregunta126Si = "";
                                    }
                                    break;
                                case "127":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta127Si = "X";
                                        newFicha.pregunta127No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta127No = "X";
                                        newFicha.pregunta127Si = "";
                                    }
                                    break;
                                case "128":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta128Si = "X";
                                        newFicha.pregunta128No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta128No = "X";
                                        newFicha.pregunta128Si = "";
                                    }
                                    break;
                                case "129":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta129Si = "X";
                                        newFicha.pregunta129No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta129No = "X";
                                        newFicha.pregunta129Si = "";
                                    }
                                    break;
                                case "130":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta130Si = "X";
                                        newFicha.pregunta130No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta130No = "X";
                                        newFicha.pregunta130Si = "";
                                    }
                                    break;
                                case "131":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta131Si = "X";
                                        newFicha.pregunta131No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta131No = "X";
                                        newFicha.pregunta131Si = "";
                                    }
                                    break;
                                case "132":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta132Si = "X";
                                        newFicha.pregunta132No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta132No = "X";
                                        newFicha.pregunta132Si = "";
                                    }
                                    break;
                                case "133":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta133Si = "X";
                                        newFicha.pregunta133No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta133No = "X";
                                        newFicha.pregunta133Si = "";
                                    }
                                    break;
                                case "134":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta134Si = "X";
                                        newFicha.pregunta134No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta134No = "X";
                                        newFicha.pregunta134Si = "";
                                    }
                                    break;
                                case "135":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta135Si = "X";
                                        newFicha.pregunta135No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta135No = "X";
                                        newFicha.pregunta135Si = "";
                                    }
                                    break;
                                case "136":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta136Si = "X";
                                        newFicha.pregunta136No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta136No = "X";
                                        newFicha.pregunta136Si = "";
                                    }
                                    break;
                                case "137":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta137Si = "X";
                                        newFicha.pregunta137No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta137No = "X";
                                        newFicha.pregunta137Si = "";
                                    }
                                    break;
                                case "138":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta138Si = "X";
                                        newFicha.pregunta138No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta138No = "X";
                                        newFicha.pregunta138Si = "";
                                    }
                                    break;
                                case "139":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta139Si = "X";
                                        newFicha.pregunta139No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta139No = "X";
                                        newFicha.pregunta139Si = "";
                                    }
                                    break;
                                case "140":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta140Si = "X";
                                        newFicha.pregunta140No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta140No = "X";
                                        newFicha.pregunta140Si = "";
                                    }
                                    break;
                                case "141":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta141Si = "X";
                                        newFicha.pregunta141No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta141No = "X";
                                        newFicha.pregunta141Si = "";
                                    }
                                    break;
                                case "142":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta142Si = "X";
                                        newFicha.pregunta142No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta142No = "X";
                                        newFicha.pregunta142Si = "";
                                    }
                                    break;
                                case "143":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta143Si = "X";
                                        newFicha.pregunta143No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta143No = "X";
                                        newFicha.pregunta143Si = "";
                                    }
                                    break;
                                case "144":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta144Si = "X";
                                        newFicha.pregunta144No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta144No = "X";
                                        newFicha.pregunta144Si = "";
                                    }
                                    break;
                                case "145":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta145Si = "X";
                                        newFicha.pregunta145No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta145No = "X";
                                        newFicha.pregunta145Si = "";
                                    }
                                    break;
                                case "146":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta146Si = "X";
                                        newFicha.pregunta146No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta146No = "X";
                                        newFicha.pregunta146Si = "";
                                    }
                                    break;
                                case "147":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta147Si = "X";
                                        newFicha.pregunta147No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta147No = "X";
                                        newFicha.pregunta147Si = "";
                                    }
                                    break;
                                case "148":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta148Si = "X";
                                        newFicha.pregunta148No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta148No = "X";
                                        newFicha.pregunta148Si = "";
                                    }
                                    break;
                                case "149":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta149Si = "X";
                                        newFicha.pregunta149No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta149No = "X";
                                        newFicha.pregunta149Si = "";
                                    }
                                    break;
                                case "150":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta150Si = "X";
                                        newFicha.pregunta150No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta150No = "X";
                                        newFicha.pregunta150Si = "";
                                    }
                                    break;
                                case "151":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta151Si = "X";
                                        newFicha.pregunta151No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta151No = "X";
                                        newFicha.pregunta151Si = "";
                                    }
                                    break;
                                case "152":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta152Si = "X";
                                        newFicha.pregunta152No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta152No = "X";
                                        newFicha.pregunta152Si = "";
                                    }
                                    break;
                                case "153":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta153Si = "X";
                                        newFicha.pregunta153No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta153No = "X";
                                        newFicha.pregunta153Si = "";
                                    }
                                    break;
                                case "154":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta154Si = "X";
                                        newFicha.pregunta154No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta154No = "X";
                                        newFicha.pregunta154Si = "";
                                    }
                                    break;
                                case "155":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta155Si = "X";
                                        newFicha.pregunta155No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta155No = "X";
                                        newFicha.pregunta155Si = "";
                                    }
                                    break;
                                case "156":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta156Si = "X";
                                        newFicha.pregunta156No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta156No = "X";
                                        newFicha.pregunta156Si = "";
                                    }
                                    break;
                                case "157":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta157Si = "X";
                                        newFicha.pregunta157No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta157No = "X";
                                        newFicha.pregunta157Si = "";
                                    }
                                    break;
                                case "158":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta158Si = "X";
                                        newFicha.pregunta158No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta158No = "X";
                                        newFicha.pregunta158Si = "";
                                    }
                                    break;
                                case "159":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta159Si = "X";
                                        newFicha.pregunta159No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta159No = "X";
                                        newFicha.pregunta159Si = "";
                                    }
                                    break;
                                case "160":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta160Si = "X";
                                        newFicha.pregunta160No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta160No = "X";
                                        newFicha.pregunta160Si = "";
                                    }
                                    break;
                                case "161":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta161Si = "X";
                                        newFicha.pregunta161No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta161No = "X";
                                        newFicha.pregunta161Si = "";
                                    }
                                    break;
                                case "162":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta162Si = "X";
                                        newFicha.pregunta162No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta162No = "X";
                                        newFicha.pregunta162Si = "";
                                    }
                                    break;
                                case "163":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta163Si = "X";
                                        newFicha.pregunta163No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta163No = "X";
                                        newFicha.pregunta163Si = "";
                                    }
                                    break;
                                case "164":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta164Si = "X";
                                        newFicha.pregunta164No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta164No = "X";
                                        newFicha.pregunta164Si = "";
                                    }
                                    break;
                                case "165":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta165Si = "X";
                                        newFicha.pregunta165No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta165No = "X";
                                        newFicha.pregunta165Si = "";
                                    }
                                    break;
                                case "166":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta166Si = "X";
                                        newFicha.pregunta166No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta166No = "X";
                                        newFicha.pregunta166Si = "";
                                    }
                                    break;
                                case "167":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta167Si = "X";
                                        newFicha.pregunta167No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta167No = "X";
                                        newFicha.pregunta167Si = "";
                                    }
                                    break;
                                case "168":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta168Si = "X";
                                        newFicha.pregunta168No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta168No = "X";
                                        newFicha.pregunta168Si = "";
                                    }
                                    break;
                                case "169":
                                    if (p.respuestaSiIfppirRespuestaFactor)
                                    {
                                        newFicha.pregunta169Si = "X";
                                        newFicha.pregunta169No = "";
                                    }
                                    else
                                    {
                                        newFicha.pregunta169No = "X";
                                        newFicha.pregunta169Si = "";
                                    }
                                    break;
                            }
                        });
                        datos25.Add(newFicha);
                        dataSource = new ReportDataSource("DataSet1", datos25);
                        this.ReportViewer1.LocalReport.ReportPath = "Reportes/FichaIdentificacionIndividual.rdlc";

                        if (newFicha.firmaFicha != "")
                        {
                            string fullname = AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 15);
                            string realPath = fullname + "DirectorServicios\\Files\\" + newFicha.firmaFicha.Substring(1, newFicha.firmaFicha.Length - 2);
                            //realPath = realPath.Replace('\\', '/');
                            ReportParameter paramLogo = new ReportParameter();
                            paramLogo.Name = "Path";
                            paramLogo.Values.Add(realPath);
                            this.ReportViewer1.LocalReport.SetParameters(paramLogo);
                        }
                        this.ReportViewer1.LocalReport.DataSources.Add(dataSource);
                    }
                    
                    break;
                case 26:
                    documento = Request.Params.Get("documento");
                    fechaFicha = Request.Params.Get("fechahistoria");
                    Serializer ser = new Serializer();                   

                    DateTime fechaHistoria = Convert.ToDateTime(fechaFicha);
                    var datos26 = new List<ReporteHistoriaIndividual>();
                    var afiliadoHistoria = db.FuanAfiliado.Where(a => a.identificacionFuanAfiliado == documento).FirstOrDefault();
                    if (afiliadoHistoria != null)
                    {
                        var historiaAfiliado = db.InfoHfdfr.Where(f => f.fechaVisitaHfdfr >= fechaHistoria && f.idFuanAfiliado == afiliadoHistoria.idFuanAfiliado)
                        .Select(r => new
                        {
                            r.fechaVisitaHfdfr,
                            r.horaInicioHfdfr,
                            r.horaFinHfdfr,
                            r.Ciudad.Departamento.nombreDepartamento,
                            r.Ciudad.nombreCiudad,
                            r.veredaInfoHfdfr,
                            r.FuanAfiliado.barrioFuanAfiliado,
                            r.FuanAfiliado.telefonoFuanAfiliado,
                            r.FuanAfiliado.primerNombreFuanAfiliado,
                            r.FuanAfiliado.segundoNombreFuanAfiliado,
                            r.FuanAfiliado.primerApellidoFuanAfiliado,
                            r.FuanAfiliado.segundoApellidoFuanAfiliado,
                            r.FuanAfiliado.TipoIdentificacion.codigoTipoIdentificacion,
                            r.FuanAfiliado.identificacionFuanAfiliado,
                            r.FuanAfiliado.numCarnetFuanAfiliado,
                            r.FuanAfiliado.puntajeSisbenFuanAfiliado,
                            r.FuanAfiliado.TipoZona.nombreTipoZona,
                            r.historiaInfoHfdfr,
                            r.firmaHfdfr
                        })
                        .FirstOrDefault();
                        
                        HistoriaHfdfr infoHistorial = ser.Deserialize<HistoriaHfdfr>(historiaAfiliado.historiaInfoHfdfr);
                        var newHistoria = new ReporteHistoriaIndividual();
                        newHistoria.fechaVisitaHfdfr = historiaAfiliado.fechaVisitaHfdfr;
                        newHistoria.horaInicio = historiaAfiliado.horaInicioHfdfr;
                        newHistoria.horaFin = historiaAfiliado.horaFinHfdfr;
                        newHistoria.nombreDepartamento = historiaAfiliado.nombreDepartamento;
                        newHistoria.nombreCiudad = historiaAfiliado.nombreCiudad;
                        newHistoria.vereda = historiaAfiliado.veredaInfoHfdfr;
                        newHistoria.barrio = historiaAfiliado.barrioFuanAfiliado;
                        newHistoria.telefono = historiaAfiliado.telefonoFuanAfiliado;
                        newHistoria.primerNombreFuanAfiliado = historiaAfiliado.primerNombreFuanAfiliado;
                        newHistoria.segundoNombreFuanAfiliado = historiaAfiliado.segundoNombreFuanAfiliado;
                        newHistoria.primerApellidoFuanAfiliado = historiaAfiliado.primerApellidoFuanAfiliado;
                        newHistoria.segundoApellidoFuanAfiliado = historiaAfiliado.segundoApellidoFuanAfiliado;
                        newHistoria.nombreCompleto = ((historiaAfiliado.primerNombreFuanAfiliado != null) ? historiaAfiliado.primerNombreFuanAfiliado : "") + " " +
                                                     ((historiaAfiliado.segundoNombreFuanAfiliado != null) ? historiaAfiliado.segundoNombreFuanAfiliado : "") + " " +
                                                     ((historiaAfiliado.primerApellidoFuanAfiliado != null) ? historiaAfiliado.primerApellidoFuanAfiliado : "") + " " +
                                                     ((historiaAfiliado.segundoApellidoFuanAfiliado != null) ? historiaAfiliado.segundoApellidoFuanAfiliado : "");
                        newHistoria.codigoTipoIdentificacion = historiaAfiliado.codigoTipoIdentificacion;
                        newHistoria.identificacionFuanAfiliado = historiaAfiliado.identificacionFuanAfiliado;
                        newHistoria.numCarnetFuanAfiliado = historiaAfiliado.numCarnetFuanAfiliado;
                        newHistoria.firmaAfiliado = historiaAfiliado.firmaHfdfr;
                        newHistoria.sisben = historiaAfiliado.puntajeSisbenFuanAfiliado.ToString();

                        newHistoria.procedenciaRural = (infoHistorial.pregunta1 == "(R) Rural") ? "X" : "";
                        newHistoria.procedenciaUrbano = (infoHistorial.pregunta1 == "(U) Urbano") ? "X" : "";
                        newHistoria.procedenciaDesplazadoViolencia = (infoHistorial.pregunta1 == "(DV) Desplazado Violencia") ? "X" : "";
                        newHistoria.procedenciaIndigena = (infoHistorial.pregunta1 == "(I) Indigena") ? "X" : "";
                        newHistoria.procedenciaOtroPais = (infoHistorial.pregunta1 == "(OP) Otro Pais") ? "X" : "";

                        newHistoria.ubicacionRural = (infoHistorial.pregunta2 == "(R) Rural") ? "X" : "";
                        newHistoria.ubicacionUrbano = (infoHistorial.pregunta2 == "(U) Urbana") ? "X" : "";
                        newHistoria.ubicacionDesplazado = (infoHistorial.pregunta2 == "(D) Desplazados") ? "X" : "";

                        newHistoria.numeroPersonasDomicilio = infoHistorial.pregunta3;
                        newHistoria.numeroPersonas618 = infoHistorial.pregunta4;
                        newHistoria.numeroPersonas618Estudian = infoHistorial.pregunta5;
                        newHistoria.numeroPersonas614 = infoHistorial.pregunta6;
                        newHistoria.numeroPersonas614Trabajan = infoHistorial.pregunta7;

                        newHistoria.aportaMadre = (infoHistorial.pregunta8.opcionMadre == true) ? "X" : "";
                        newHistoria.aportaPadre = (infoHistorial.pregunta8.opcionPadre == true) ? "X" : "";
                        newHistoria.aportaHijos = (infoHistorial.pregunta8.opcionHijos == true) ? "X" : "";
                        newHistoria.aportaOtro = (infoHistorial.pregunta8.opcionOtros == true) ? "X" : "";

                        newHistoria.numeroPersonasmayores65 = infoHistorial.pregunta9;
                        newHistoria.numeroPersonasmayores65Trabajan = infoHistorial.pregunta10;
                        newHistoria.numeroPersonas1565 = infoHistorial.pregunta11;
                        newHistoria.numeroPersonas1565trabajan = infoHistorial.pregunta12;
                        newHistoria.totalIngresosFamilia = infoHistorial.pregunta13;

                        foreach(var item14 in infoHistorial.pregunta14)
                        {
                            if(item14.nivel == "A - PRIMARIA INCOMPLETA")
                            {
                                if(item14.madre == true)
                                {
                                    newHistoria.primariaIncompletaMadre = "X";
                                }
                                else
                                {
                                    newHistoria.primariaIncompletaMadre = "";
                                }
                                if (item14.padre == true)
                                {
                                    newHistoria.primariaIncompletaPadre = "X";
                                }
                                else
                                {
                                    newHistoria.primariaIncompletaPadre = "";
                                }
                            }
                            if (item14.nivel == "B - PRIMARIA COMPLETA")
                            {
                                if (item14.madre == true)
                                {
                                    newHistoria.primariaCompletaMadre = "X";
                                }
                                else
                                {
                                    newHistoria.primariaCompletaMadre = "";
                                }
                                if (item14.padre == true)
                                {
                                    newHistoria.primariaCompletaPadre = "X";
                                }
                                else
                                {
                                    newHistoria.primariaCompletaPadre = "";
                                }
                            }
                            if (item14.nivel == "C - BACHILLERATO INCOMPLETO")
                            {
                                if (item14.madre == true)
                                {
                                    newHistoria.bachilleratoIncompletaMadre = "X";
                                }
                                else
                                {
                                    newHistoria.bachilleratoIncompletaMadre = "";
                                }
                                if (item14.padre == true)
                                {
                                    newHistoria.bachilleratoIncompletaPadre = "X";
                                }
                                else
                                {
                                    newHistoria.bachilleratoIncompletaPadre = "";
                                }
                            }
                            if (item14.nivel == "D - BACHILLERATO COMPLETO")
                            {
                                if (item14.madre == true)
                                {
                                    newHistoria.bachilleratoCompletaMadre = "X";
                                }
                                else
                                {
                                    newHistoria.bachilleratoCompletaMadre = "";
                                }
                                if (item14.padre == true)
                                {
                                    newHistoria.bachilleratoCompletaPadre = "X";
                                }
                                else
                                {
                                    newHistoria.bachilleratoCompletaPadre = "";
                                }
                            }
                            if (item14.nivel == "E - TÉCNICOS")
                            {
                                if (item14.madre == true)
                                {
                                    newHistoria.tecnicosCompletaMadre = "X";
                                }
                                else
                                {
                                    newHistoria.tecnicosCompletaMadre = "";
                                }
                                if (item14.padre == true)
                                {
                                    newHistoria.tecnicosCompletaPadre = "X";
                                }
                                else
                                {
                                    newHistoria.tecnicosCompletaPadre = "";
                                }
                            }
                            if (item14.nivel == "F - UNIVERSITARIOS")
                            {
                                if (item14.madre == true)
                                {
                                    newHistoria.universitariosMadre = "X";
                                }
                                else
                                {
                                    newHistoria.universitariosMadre = "";
                                }
                                if (item14.padre == true)
                                {
                                    newHistoria.universitariosPadre = "X";
                                }
                                else
                                {
                                    newHistoria.universitariosPadre = "";
                                }
                            }
                            if (item14.nivel == "G - EDUCACIÓN NO FORMAL")
                            {
                                if (item14.madre == true)
                                {
                                    newHistoria.educacionNoFormalMadre = "X";
                                }
                                else
                                {
                                    newHistoria.educacionNoFormalMadre = "";
                                }
                                if (item14.padre == true)
                                {
                                    newHistoria.educacionNoFormalPadre = "X";
                                }
                                else
                                {
                                    newHistoria.educacionNoFormalPadre = "";
                                }
                            }
                            if (item14.nivel == "H - OTROS")
                            {
                                if (item14.madre == true)
                                {
                                    newHistoria.otrosMadre = "X";
                                }
                                else
                                {
                                    newHistoria.otrosMadre = "";
                                }
                                if (item14.padre == true)
                                {
                                    newHistoria.otrosPadre = "X";
                                }
                                else
                                {
                                    newHistoria.otrosPadre = "";
                                }
                            }
                            if (item14.nivel == "I - NINGUNO")
                            {
                                if (item14.madre == true)
                                {
                                    newHistoria.ningunEstudioMadre = "X";
                                }
                                else
                                {
                                    newHistoria.ningunEstudioMadre = "";
                                }
                                if (item14.padre == true)
                                {
                                    newHistoria.ningunEstudioPadre = "X";
                                }
                                else
                                {
                                    newHistoria.ningunEstudioPadre = "";
                                }
                            }
                        }

                        newHistoria.pisoBloque = (infoHistorial.pregunta15.opcionA == "BLOQUE") ? "X" : "";
                        newHistoria.pisoTierra = (infoHistorial.pregunta15.opcionA == "TIERRA") ? "X" : "";
                        newHistoria.pisoCemento = (infoHistorial.pregunta15.opcionA == "CEMENTO") ? "X" : "";
                        newHistoria.pisoMadera = (infoHistorial.pregunta15.opcionA == "MADERA") ? "X" : "";
                        newHistoria.pisoCarton = (infoHistorial.pregunta15.opcionA == "CARTON") ? "X" : "";
                        newHistoria.pisoPrefabricado = (infoHistorial.pregunta15.opcionA == "PREFABRICADO") ? "X" : "";
                        newHistoria.pisoAdobe = (infoHistorial.pregunta15.opcionA == "ADOBE") ? "X" : "";
                        newHistoria.pisoGuadua = (infoHistorial.pregunta15.opcionA == "GUADUA") ? "X" : "";
                        newHistoria.pisoParoy = (infoHistorial.pregunta15.opcionA == "PAROY") ? "X" : "";
                        newHistoria.pisoZing = (infoHistorial.pregunta15.opcionA == "ZING") ? "X" : "";
                        newHistoria.pisoPalma = (infoHistorial.pregunta15.opcionA == "PALMA") ? "X" : "";
                        newHistoria.pisoBarro = (infoHistorial.pregunta15.opcionA == "BARRO") ? "X" : "";
                        newHistoria.pisoLadrillo = (infoHistorial.pregunta15.opcionA == "LADRILLO") ? "X" : "";
                        newHistoria.pisoOtro = (infoHistorial.pregunta15.opcionA == "OTRO") ? "X" : "";

                        newHistoria.techoBloque = (infoHistorial.pregunta15.opcionB == "BLOQUE") ? "X" : "";
                        newHistoria.techoTierra = (infoHistorial.pregunta15.opcionB == "TIERRA") ? "X" : "";
                        newHistoria.techoCemento = (infoHistorial.pregunta15.opcionB == "CEMENTO") ? "X" : "";
                        newHistoria.techoMadera = (infoHistorial.pregunta15.opcionB == "MADERA") ? "X" : "";
                        newHistoria.techoCarton = (infoHistorial.pregunta15.opcionB == "CARTON") ? "X" : "";
                        newHistoria.techoPrefabricado = (infoHistorial.pregunta15.opcionB == "PREFABRICADO") ? "X" : "";
                        newHistoria.techoAdobe = (infoHistorial.pregunta15.opcionB == "ADOBE") ? "X" : "";
                        newHistoria.techoGuadua = (infoHistorial.pregunta15.opcionB == "GUADUA") ? "X" : "";
                        newHistoria.techoParoy = (infoHistorial.pregunta15.opcionB == "PAROY") ? "X" : "";
                        newHistoria.techoZing = (infoHistorial.pregunta15.opcionB == "ZING") ? "X" : "";
                        newHistoria.techoPalma = (infoHistorial.pregunta15.opcionB == "PALMA") ? "X" : "";
                        newHistoria.techoBarro = (infoHistorial.pregunta15.opcionB == "BARRO") ? "X" : "";
                        newHistoria.techoLadrillo = (infoHistorial.pregunta15.opcionB == "LADRILLO") ? "X" : "";
                        newHistoria.techoOtro = (infoHistorial.pregunta15.opcionB == "OTRO") ? "X" : "";

                        newHistoria.paredesBloque = (infoHistorial.pregunta15.opcionC == "BLOQUE") ? "X" : "";
                        newHistoria.paredesTierra = (infoHistorial.pregunta15.opcionC == "TIERRA") ? "X" : "";
                        newHistoria.paredesCemento = (infoHistorial.pregunta15.opcionC == "CEMENTO") ? "X" : "";
                        newHistoria.paredesMadera = (infoHistorial.pregunta15.opcionC == "MADERA") ? "X" : "";
                        newHistoria.paredesCarton = (infoHistorial.pregunta15.opcionC == "CARTON") ? "X" : "";
                        newHistoria.paredesPrefabricado = (infoHistorial.pregunta15.opcionC == "PREFABRICADO") ? "X" : "";
                        newHistoria.paredesAdobe = (infoHistorial.pregunta15.opcionC == "ADOBE") ? "X" : "";
                        newHistoria.paredesGuadua = (infoHistorial.pregunta15.opcionC == "GUADUA") ? "X" : "";
                        newHistoria.paredesParoy = (infoHistorial.pregunta15.opcionC == "PAROY") ? "X" : "";
                        newHistoria.paredesZing = (infoHistorial.pregunta15.opcionC == "ZING") ? "X" : "";
                        newHistoria.paredesPalma = (infoHistorial.pregunta15.opcionC == "PALMA") ? "X" : "";
                        newHistoria.paredesBarro = (infoHistorial.pregunta15.opcionC == "BARRO") ? "X" : "";
                        newHistoria.paredesLadrillo = (infoHistorial.pregunta15.opcionC == "LADRILLO") ? "X" : "";
                        newHistoria.paredesOtro = (infoHistorial.pregunta15.opcionC == "OTRO") ? "X" : "";
                        
                        newHistoria.numeroHabitaciones = infoHistorial.pregunta15.opcionD;
                        newHistoria.numeroCamasDomicilio = infoHistorial.pregunta15.opcionE;
                        if(infoHistorial.pregunta15.opcionF == "(1) CASA")
                        {
                            newHistoria.tipoViviendaCasa = "X";
                        }
                        if (infoHistorial.pregunta15.opcionF == "(2) APARTAMENTO")
                        {
                            newHistoria.tipoViviendaApartamento = "X";
                        }
                        if (infoHistorial.pregunta15.opcionF == "(3) CUARTO")
                        {
                            newHistoria.tipoViviendaCuarto = "X";
                        }
                        if (infoHistorial.pregunta15.opcionF == "(4) ALBERGUE")
                        {
                            newHistoria.tipoViviendaAlbergue = "X";
                        }
                        if (infoHistorial.pregunta15.opcionF == "(5) HABITANTE DE CALLE")
                        {
                            newHistoria.tipoViviendaHabitanteCalle = "X";
                        }
                        if(infoHistorial.pregunta15.opcionG == "(1) PROPIA")
                        {
                            newHistoria.tenenciaPropia = "X";
                        }
                        if (infoHistorial.pregunta15.opcionG == "(2) ARRIENDO")
                        {
                            newHistoria.tenenciaArriendo = "X";
                        }
                        if (infoHistorial.pregunta15.opcionG == "(3) FAMILIAR")
                        {
                            newHistoria.tenenciaFamiliar = "X";
                        }
                        if (infoHistorial.pregunta15.opcionG == "(4) NINGUNA")
                        {
                            newHistoria.tenenciaNinguna = "X";
                        }
                        if(infoHistorial.pregunta16 == "SI")
                        {
                            newHistoria.familiaCocinaDuermeSi = "X";
                        }
                        if (infoHistorial.pregunta16 == "NO")
                        {
                            newHistoria.familiaCocinaDuermeNo = "X";
                        }
                        if (infoHistorial.pregunta16 == "N.A")
                        {
                            newHistoria.familiaCocinaDuermeNa = "X";
                        }
                        if(infoHistorial.pregunta17 == "(A) LEÑA")
                        {
                            newHistoria.combustibleLena = "X";
                        }
                        if (infoHistorial.pregunta17 == "(B) CARBON")
                        {
                            newHistoria.combustibleCarbon = "X";
                        }
                        if (infoHistorial.pregunta17 == "(C) ELECTRICIDAD")
                        {
                            newHistoria.combustibleElectricidad = "X";
                        }
                        if (infoHistorial.pregunta17 == "(D) GAS")
                        {
                            newHistoria.combustibleGas = "X";
                        }
                        if (infoHistorial.pregunta17 == "(E) GASOLINA")
                        {
                            newHistoria.combustibleGasolina = "X";
                        }
                        if (infoHistorial.pregunta17 == "(F) PETROLEO")
                        {
                            newHistoria.combustiblePetroleo = "X";
                        }
                        if (infoHistorial.pregunta17 == "(G) OTRO")
                        {
                            newHistoria.combustibleOtro = "X";
                        }
                        if (infoHistorial.pregunta17 == "(H) NO APLICA")
                        {
                            newHistoria.combustibleNoAplica = "X";
                        }
                        if(infoHistorial.pregunta18 == "(A) SIN TRATAMIENTO")
                        {
                            newHistoria.tratamientoAguaNo = "X";
                        }
                        if (infoHistorial.pregunta18 == "(B) CLORADA")
                        {
                            newHistoria.tratamientoAguaClorada = "X";
                        }
                        if (infoHistorial.pregunta18 == "(C) FILTRADA")
                        {
                            newHistoria.tratamientoAguaFiltrada = "X";
                        }
                        if (infoHistorial.pregunta18 == "(D) HERVIDA")
                        {
                            newHistoria.tratamientoAguaHervida = "X";
                        }
                        if (infoHistorial.pregunta19 == "SI")
                        {
                            newHistoria.recipientesDesinfectadosSi = "X";
                        }
                        if (infoHistorial.pregunta19 == "NO")
                        {
                            newHistoria.recipientesDesinfectadosNo = "X";
                        }
                        if (infoHistorial.pregunta19 == "N.A")
                        {
                            newHistoria.recipientesDesinfectadosNa = "X";
                        }
                        if(infoHistorial.pregunta20.opcionA == true)
                        {
                            newHistoria.viviendaServicioLuz = "X";
                        }
                        else
                        {
                            newHistoria.viviendaServicioLuz = "";
                        }
                        if (infoHistorial.pregunta20.opcionB == true)
                        {
                            newHistoria.viviendaServicioAgua = "X";
                        }
                        else
                        {
                            newHistoria.viviendaServicioAgua = "";
                        }
                        if (infoHistorial.pregunta20.opcionC == true)
                        {
                            newHistoria.viviendaServicioTelefono = "X";
                        }
                        else
                        {
                            newHistoria.viviendaServicioTelefono = "";
                        }
                        if (infoHistorial.pregunta20.opcionD == true)
                        {
                            newHistoria.viviendaServicioAlcantarillado = "X";
                        }
                        else
                        {
                            newHistoria.viviendaServicioAlcantarillado = "";
                        }
                        if (infoHistorial.pregunta20.opcionE == true)
                        {
                            newHistoria.viviendaServicioRecoleccionBasura = "X";
                        }
                        else
                        {
                            newHistoria.viviendaServicioRecoleccionBasura = "";
                        }
                        if (infoHistorial.pregunta20.opcionF == true)
                        {
                            newHistoria.viviendaServicioNoAplica = "X";
                        }
                        else
                        {
                            newHistoria.viviendaServicioNoAplica = "";
                        }
                        if(infoHistorial.pregunta21 == "(A) LETRINA")
                        {
                            newHistoria.dispoExcresasLetrina = "X";
                        }
                        if (infoHistorial.pregunta21 == "(B) SANITARIO CON CONEXION A ALCANTARILLADO")
                        {
                            newHistoria.dispoExcresasSanitarioAlcantarillado = "X";
                        }
                        if (infoHistorial.pregunta21 == "(C) SANITARIO CONECTADO A POZO SEPTICO")
                        {
                            newHistoria.dispoExcresasSanitarioPozo = "X";
                        }
                        if (infoHistorial.pregunta21 == "(D) INODORO SIN CONEXION A ALCANTARILLADO O POZO SEPTICO")
                        {
                            newHistoria.dispoExcresasInodoroSinConexion = "X";
                        }
                        if (infoHistorial.pregunta21 == "(E) NO TIENE SANITARIO")
                        {
                            newHistoria.dispoExcresasNoSanitario = "X";
                        }
                        if(infoHistorial.pregunta22 == "ADECUADO")
                        {
                            newHistoria.manejoBasurasAdecuado = "X";
                        }
                        if (infoHistorial.pregunta22 == "INADECUADO")
                        {
                            newHistoria.manejoBasurasInadecuado = "X";
                        }
                        if (infoHistorial.pregunta22 == "N.A")
                        {
                            newHistoria.manejoBasurasNoAplica = "X";
                        }
                        if(infoHistorial.pregunta23 == "(A) QUEMA")
                        {
                            newHistoria.disposicionBasuraQuema = "X";
                        }
                        if (infoHistorial.pregunta23 == "(B) ENTIERRA")
                        {
                            newHistoria.disposicionBasuraEntierra = "X";
                        }
                        if (infoHistorial.pregunta23 == "(C) ARROJAN RIO O CAÑO")
                        {
                            newHistoria.disposicionBasuraArrojaRio = "X";
                        }
                        if (infoHistorial.pregunta23 == "(D) DEJAN AL AIRE LIBRE")
                        {
                            newHistoria.disposicionBasuraAireLibre = "X";
                        }
                        if (infoHistorial.pregunta23 == "(E) RECOGE SERVICIO PUBLICO")
                        {
                            newHistoria.disposicionBasuraRecogeServicio = "X";
                        }
                        if (infoHistorial.pregunta23 == "(F) OTRO")
                        {
                            newHistoria.disposicionBasuraOtro = "X";
                        }
                        if(infoHistorial.pregunta24.opcionA == true)
                        {
                            newHistoria.frDispInadecuadaBasura = "X";
                        }
                        else
                        {
                            newHistoria.frDispInadecuadaBasura = "";
                        }
                        if (infoHistorial.pregunta24.opcionB == true)
                        {
                            newHistoria.frCanosRiosContaminados = "X";
                        }
                        else
                        {
                            newHistoria.frCanosRiosContaminados = "";
                        }
                        if (infoHistorial.pregunta24.opcionC == true)
                        {
                            newHistoria.frDeslizamientoTierra = "X";
                        }
                        else
                        {
                            newHistoria.frDeslizamientoTierra = "";
                        }
                        if (infoHistorial.pregunta24.opcionD == true)
                        {
                            newHistoria.frAreneras = "X";
                        }
                        else
                        {
                            newHistoria.frAreneras = "";
                        }
                        if (infoHistorial.pregunta24.opcionE == true)
                        {
                            newHistoria.frCarboneras = "X";
                        }
                        else
                        {
                            newHistoria.frCarboneras = "";
                        }
                        if (infoHistorial.pregunta24.opcionF1 == true)
                        {
                            newHistoria.frRoedores = "X";
                        }
                        else
                        {
                            newHistoria.frRoedores = "";
                        }
                        if (infoHistorial.pregunta24.opcionF2 == true)
                        {
                            newHistoria.frInsectos = "X";
                        }
                        else
                        {
                            newHistoria.frInsectos = "";
                        }
                        if (infoHistorial.pregunta24.opcionG == true)
                        {
                            newHistoria.frInundaciones = "X";
                        }
                        else
                        {
                            newHistoria.frInundaciones = "";
                        }
                        if (infoHistorial.pregunta24.opcionH == true)
                        {
                            newHistoria.frInseguridad = "X";
                        }
                        else
                        {
                            newHistoria.frInseguridad = "";
                        }
                        if (infoHistorial.pregunta24.opcionI == true)
                        {
                            newHistoria.frProstitucion = "X";
                        }
                        else
                        {
                            newHistoria.frProstitucion = "";
                        }
                        if (infoHistorial.pregunta24.opcionJ == true)
                        {
                            newHistoria.frPandillismo = "X";
                        }
                        else
                        {
                            newHistoria.frPandillismo = "";
                        }
                        if (infoHistorial.pregunta24.opcionK == true)
                        {
                            newHistoria.frDrogadiccion = "X";
                        }
                        else
                        {
                            newHistoria.frDrogadiccion = "";
                        }
                        if (infoHistorial.pregunta24.opcionL == true)
                        {
                            newHistoria.frAlcoholismo = "X";
                        }
                        else
                        {
                            newHistoria.frAlcoholismo = "";
                        }
                        if (infoHistorial.pregunta24.opcionM == true)
                        {
                            newHistoria.frViolencia = "X";
                        }
                        else
                        {
                            newHistoria.frViolencia = "";
                        }
                        if (infoHistorial.pregunta24.opcionN == true)
                        {
                            newHistoria.frOtro = "X";
                        }
                        else
                        {
                            newHistoria.frOtro = "";
                        }
                        if (infoHistorial.pregunta24.opcionO == true)
                        {
                            newHistoria.frNinguna = "X";
                        }
                        else
                        {
                            newHistoria.frNinguna = "";
                        }
                        if(infoHistorial.pregunta25 == "SI")
                        {
                            newHistoria.animalesSi = "X";
                        }
                        if (infoHistorial.pregunta25 == "NO")
                        {
                            newHistoria.animalesNo = "X";
                        }
                        foreach(var item26 in infoHistorial.pregunta26)
                        {
                            if(item26.nombreAnimal == "A - CANINOS")
                            {
                                newHistoria.numeroCaninos = item26.numero.ToString();
                            }
                            if (item26.nombreAnimal == "B - AVES")
                            {
                                newHistoria.numeroAves = item26.numero.ToString();
                            }
                            if (item26.nombreAnimal == "C - PORCINOS")
                            {
                                newHistoria.numeroPorcinos = item26.numero.ToString();
                            }
                            if (item26.nombreAnimal == "D - OVINOS")
                            {
                                newHistoria.numeroOvinos = item26.numero.ToString();
                            }
                            if (item26.nombreAnimal == "E - EQUINOS")
                            {
                                newHistoria.numeroEquinos = item26.numero.ToString();
                            }
                            if (item26.nombreAnimal == "F - ROEDORES")
                            {
                                newHistoria.numeroRoedores = item26.numero.ToString();
                            }
                            if (item26.nombreAnimal == "G - OFIDIOS")
                            {
                                newHistoria.numeroOfidios = item26.numero.ToString();
                            }
                            if (item26.nombreAnimal == "H - FELINOS")
                            {
                                newHistoria.numeroFelinos = item26.numero.ToString();
                            }
                            if (item26.nombreAnimal == "I - BOVINOS")
                            {
                                newHistoria.numeroBovinos = item26.numero.ToString();
                            }
                            if (item26.nombreAnimal == "J - OTROS")
                            {
                                newHistoria.numeroOtros = item26.numero.ToString();
                            }
                            if (item26.nombreAnimal == "K - N.A.")
                            {
                                newHistoria.numeroNa = item26.numero.ToString();
                            }
                            if(infoHistorial.pregunta27.opcionA == true)
                            {
                                newHistoria.vacunadoCaninos = "X";
                            }
                            else
                            {
                                newHistoria.vacunadoCaninos = "";
                            }
                            if (infoHistorial.pregunta27.opcionB == true)
                            {
                                newHistoria.vacunadoAves = "X";
                            }
                            else
                            {
                                newHistoria.vacunadoAves = "";
                            }
                            if (infoHistorial.pregunta27.opcionC == true)
                            {
                                newHistoria.vacunadoPorcinos = "X";
                            }
                            else
                            {
                                newHistoria.vacunadoPorcinos = "";
                            }
                            if (infoHistorial.pregunta27.opcionD == true)
                            {
                                newHistoria.vacunadoOvinos = "X";
                            }
                            else
                            {
                                newHistoria.vacunadoOvinos = "";
                            }
                            if (infoHistorial.pregunta27.opcionE == true)
                            {
                                newHistoria.vacunadoEquinos = "X";
                            }
                            else
                            {
                                newHistoria.vacunadoEquinos = "";
                            }
                            if (infoHistorial.pregunta27.opcionF == true)
                            {
                                newHistoria.vacunadoFelinos = "X";
                            }
                            else
                            {
                                newHistoria.vacunadoFelinos = "";
                            }
                        }
                       
                        newHistoria.numeroNoControlOdontologico = infoHistorial.pregunta29;
                        newHistoria.mujer60SinControlMedico = infoHistorial.pregunta30.personasF;
                        newHistoria.hombre60SinControlMedico = infoHistorial.pregunta30.personasM;
                        newHistoria.na60SinControlMedico = infoHistorial.pregunta30.personasNA;
                        
                        newHistoria.corrigeCompCastigoFisico = (infoHistorial.pregunta34.opcionA == true) ? "X" : "";
                        newHistoria.corrigeCompRegano = (infoHistorial.pregunta34.opcionB == true) ? "X" : "";
                        newHistoria.corrigeCompEncierro = (infoHistorial.pregunta34.opcionC == true) ? "X" : "";
                        newHistoria.corrigeCompZarandeo = (infoHistorial.pregunta34.opcionD == true) ? "X" : "";
                        newHistoria.corrigeCompPrivacion = (infoHistorial.pregunta34.opcionE == true) ? "X" : "";
                        newHistoria.corrigeCompDialogo = (infoHistorial.pregunta34.opcionF == true) ? "X" : "";
                        newHistoria.corrigeCompAislamiento = (infoHistorial.pregunta34.opcionG == true) ? "X" : "";
                        newHistoria.corrigeCompOtro = (infoHistorial.pregunta34.opcionH == true) ? "X" : "";

                        newHistoria.nino12cocinaSi = (infoHistorial.pregunta35 == "SI") ? "X" : "";
                        newHistoria.nino12cocinaNo = (infoHistorial.pregunta35 == "NO") ? "X" : "";

                        newHistoria.solConflictosDialogando = (infoHistorial.pregunta36.opcionA == true) ? "X" : "";
                        newHistoria.solConflictosAgresionFisica = (infoHistorial.pregunta36.opcionB == true) ? "X" : "";
                        newHistoria.solConflictosPrivacionEconomica = (infoHistorial.pregunta36.opcionC == true) ? "X" : "";
                        newHistoria.solConflictosAgresionVerbal = (infoHistorial.pregunta36.opcionD == true) ? "X" : "";
                        newHistoria.solConflictosPrivacion = (infoHistorial.pregunta36.opcionE == true) ? "X" : "";
                        newHistoria.solConflictosAgresionSexual = (infoHistorial.pregunta36.opcionF == true) ? "X" : "";
                        newHistoria.solConflictosOtros = (infoHistorial.pregunta36.opcionG == true) ? "X" : "";
                        newHistoria.solConflictosSinDato = (infoHistorial.pregunta36.opcionH == true) ? "X" : "";

                        newHistoria.conflictosHogarSi = (infoHistorial.pregunta37 == "SI") ? "X" : "";
                        newHistoria.conflictosHogarNo = (infoHistorial.pregunta37 == "NO") ? "X" : "";

                        newHistoria.agredePapa = (infoHistorial.pregunta38.opcionA == true) ? "X" : "";
                        newHistoria.agredeMama = (infoHistorial.pregunta38.opcionB == true) ? "X" : "";
                        newHistoria.agredeHijos = (infoHistorial.pregunta38.opcionC == true) ? "X" : "";
                        newHistoria.agredePadrastro = (infoHistorial.pregunta38.opcionD == true) ? "X" : "";
                        newHistoria.agredeNoClaro = (infoHistorial.pregunta38.opcionE == true) ? "X" : "";
                        newHistoria.agredeNoAplica = (infoHistorial.pregunta38.opcionF == true) ? "X" : "";

                        newHistoria.actividadesFamiliaDeportivas = (infoHistorial.pregunta39.opcionA == true) ? "X" : "";
                        newHistoria.actividadesFamiliaRecreativas = (infoHistorial.pregunta39.opcionB == true) ? "X" : "";
                        newHistoria.actividadesFamiliaEspirituales = (infoHistorial.pregunta39.opcionC == true) ? "X" : "";
                        newHistoria.actividadesFamiliaSociales = (infoHistorial.pregunta39.opcionD == true) ? "X" : "";
                        newHistoria.actividadesFamiliaNinguna = (infoHistorial.pregunta39.opcionE == true) ? "X" : "";
                        newHistoria.actividadesFamiliaOtra = (infoHistorial.pregunta39.opcionF == true) ? "X" : "";

                        newHistoria.actividades60FamiliaDeportivas = (infoHistorial.pregunta40.opcionA == true) ? "X" : "";
                        newHistoria.actividades60FamiliaRecreativas = (infoHistorial.pregunta40.opcionB == true) ? "X" : "";
                        newHistoria.actividades60FamiliaEspirituales = (infoHistorial.pregunta40.opcionC == true) ? "X" : "";
                        newHistoria.actividades60FamiliaSociales = (infoHistorial.pregunta40.opcionD == true) ? "X" : "";
                        newHistoria.actividades60FamiliaNinguna = (infoHistorial.pregunta40.opcionE == true) ? "X" : "";
                        newHistoria.actividades60FamiliaOtra = (infoHistorial.pregunta40.opcionF == true) ? "X" : "";

                        newHistoria.comparteMamaSi = (infoHistorial.pregunta41.opcionMama == "SI") ? "X" : "";
                        newHistoria.comparteMamaNo = (infoHistorial.pregunta41.opcionMama == "NO") ? "X" : "";
                        newHistoria.comparteMamaAveces = (infoHistorial.pregunta41.opcionMama == "AVECES") ? "X" : "";
                        newHistoria.compartePapaSi = (infoHistorial.pregunta41.opcionPapa == "SI") ? "X" : "";
                        newHistoria.compartePapaNo = (infoHistorial.pregunta41.opcionPapa == "NO") ? "X" : "";
                        newHistoria.compartePapaAveces = (infoHistorial.pregunta41.opcionPapa == "AVECES") ? "X" : "";
                        newHistoria.comparteOtroSi = (infoHistorial.pregunta41.opcionOtro == "SI") ? "X" : "";
                        newHistoria.comparteOtroNo = (infoHistorial.pregunta41.opcionOtro == "NO") ? "X" : "";
                        newHistoria.comparteOtroAveces = (infoHistorial.pregunta41.opcionOtro == "AVECES") ? "X" : "";
                        newHistoria.comparteNinguno = (infoHistorial.pregunta41.opcionNinguno == true) ? "X" : "";

                        newHistoria.causaNoComparteTrabajo = (infoHistorial.pregunta42.opcionA == true) ? "X" : "";
                        newHistoria.causaNoComparteDescansan = (infoHistorial.pregunta42.opcionB == true) ? "X" : "";
                        newHistoria.causaNoComparteNiñosJueguenSolos = (infoHistorial.pregunta42.opcionC == true) ? "X" : "";
                        newHistoria.causaNoComparteNoAplica = (infoHistorial.pregunta42.opcionD == true) ? "X" : "";
                        newHistoria.causaNoComparteOtras = (infoHistorial.pregunta42.opcionE == true) ? "X" : "";

                        newHistoria.orientacionSexualSi = (infoHistorial.pregunta43 == "SI") ? "X" : "";
                        newHistoria.orientacionSexualNo = (infoHistorial.pregunta43 == "NO") ? "X" : "";

                        newHistoria.orientacionHijosDialogo = (infoHistorial.pregunta44.opcionA == true) ? "X" : "";
                        newHistoria.orientacionHijosColegio = (infoHistorial.pregunta44.opcionB == true) ? "X" : "";
                        newHistoria.orientacionHijosNoLoRealiza = (infoHistorial.pregunta44.opcionC == true) ? "X" : "";

                        newHistoria.tiempoEjercicioEdad = infoHistorial.pregunta45.edad.ToString();
                        newHistoria.tiempoEjerciciomenos30 = (infoHistorial.pregunta42.opcionA == true) ? "X" : "";
                        newHistoria.tiempoEjerciciomenos5dias = (infoHistorial.pregunta42.opcionB == true) ? "X" : "";
                        newHistoria.tiempoEjercicioSemana = (infoHistorial.pregunta42.opcionC == true) ? "X" : "";
                        newHistoria.tiempoEjercicioNoRealiza = (infoHistorial.pregunta42.opcionD == true) ? "X" : "";

                        newHistoria.discapacitados = infoHistorial.pregunta28;
                        newHistoria.integrantesEspectoracion = infoHistorial.pregunta31;
                        newHistoria.integrantesManchasPiel = infoHistorial.pregunta32;
                        newHistoria.integrantesEnfermosVisita = infoHistorial.pregunta33;

                        


                        datos26.Add(newHistoria);
                        

                        dataSource = new ReportDataSource("DataSet1", datos26);

                        //Agrego los listados en un DataSource por aparte
                        ReportDataSource dataSourceIncapacitados = null;
                        dataSourceIncapacitados = new ReportDataSource("DataSetIncapacitados", newHistoria.discapacitados);

                        ReportDataSource dataSourceEspectorante = null;
                        dataSourceEspectorante = new ReportDataSource("DataSetEspectorante", newHistoria.integrantesEspectoracion);

                        ReportDataSource dataSourceManchasPiel = null;
                        dataSourceManchasPiel = new ReportDataSource("DataSetManchasPiel", newHistoria.integrantesManchasPiel);

                        ReportDataSource dataSourceEnfermosVisita = null;
                        dataSourceEnfermosVisita = new ReportDataSource("DataSetEnfermosVisita", newHistoria.integrantesEnfermosVisita);

                       
                        this.ReportViewer1.LocalReport.ReportPath = "Reportes/HistoriaIndividual.rdlc";

                        if (newHistoria.firmaAfiliado != "")
                        {
                            string fullname = AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 15);
                            string realPath = fullname + "DirectorServicios\\Files\\" + newHistoria.firmaAfiliado.Substring(1, newHistoria.firmaAfiliado.Length - 2);
                            //realPath = realPath.Replace('\\', '/');
                            ReportParameter paramLogo = new ReportParameter();
                            paramLogo.Name = "Path";
                            paramLogo.Values.Add(realPath);
                            this.ReportViewer1.LocalReport.SetParameters(paramLogo);
                        }
                        this.ReportViewer1.LocalReport.DataSources.Add(dataSource);
                        this.ReportViewer1.LocalReport.DataSources.Add(dataSourceIncapacitados);
                        this.ReportViewer1.LocalReport.DataSources.Add(dataSourceEspectorante);
                        this.ReportViewer1.LocalReport.DataSources.Add(dataSourceManchasPiel);
                        this.ReportViewer1.LocalReport.DataSources.Add(dataSourceEnfermosVisita);
                        //firma del afiliado
                        
                    }
                    break;
                case 27:
                    documento = Request.Params.Get("documento");
                    break;
                case 28:
                    documento = Request.Params.Get("documento");
                    break;
            }

            this.ReportViewer1.LocalReport.Refresh();
        }
    }
}