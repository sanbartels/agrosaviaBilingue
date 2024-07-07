//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.18.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>PQRS</summary>
	[PublishedModel("pQRS")]
	public partial class PQrs : PublishedContentModel, IMenu
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		public new const string ModelTypeAlias = "pQRS";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PQrs, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public PQrs(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Descripcion seccion
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		[ImplementPropertyType("descripcionSeccion")]
		public virtual global::System.Web.IHtmlString DescripcionSeccion => this.Value<global::System.Web.IHtmlString>("descripcionSeccion");

		///<summary>
		/// Listado pqrs
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		[ImplementPropertyType("listadoPqrs")]
		public virtual global::Umbraco.Core.Models.Blocks.BlockListModel ListadoPqrs => this.Value<global::Umbraco.Core.Models.Blocks.BlockListModel>("listadoPqrs");

		///<summary>
		/// Subtitulo descripcion
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		[ImplementPropertyType("subtituloDescripcion")]
		public virtual string SubtituloDescripcion => this.Value<string>("subtituloDescripcion");

		///<summary>
		/// Titulo interno seccion
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		[ImplementPropertyType("tituloInternoSeccion")]
		public virtual string TituloInternoSeccion => this.Value<string>("tituloInternoSeccion");

		///<summary>
		/// MostrarEnMenu
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		[ImplementPropertyType("mostrarEnMenu")]
		public virtual bool MostrarEnMenu => global::Umbraco.Web.PublishedModels.Menu.GetMostrarEnMenu(this);

		///<summary>
		/// Nombre en menu
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		[ImplementPropertyType("nombreEnMenu")]
		public virtual string NombreEnMenu => global::Umbraco.Web.PublishedModels.Menu.GetNombreEnMenu(this);
	}
}
