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
	/// <summary>Producto</summary>
	[PublishedModel("producto")]
	public partial class Producto : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		public new const string ModelTypeAlias = "producto";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Producto, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Producto(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Categoria
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		[ImplementPropertyType("categoria")]
		public virtual global::System.Collections.Generic.IEnumerable<string> Categoria => this.Value<global::System.Collections.Generic.IEnumerable<string>>("categoria");

		///<summary>
		/// Descripcion producto
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		[ImplementPropertyType("descripcionProducto")]
		public virtual global::System.Web.IHtmlString DescripcionProducto => this.Value<global::System.Web.IHtmlString>("descripcionProducto");

		///<summary>
		/// Nombre producto
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		[ImplementPropertyType("nombreProducto")]
		public virtual string NombreProducto => this.Value<string>("nombreProducto");

		///<summary>
		/// Resumen producto
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		[ImplementPropertyType("resumenProducto")]
		public virtual global::System.Web.IHtmlString ResumenProducto => this.Value<global::System.Web.IHtmlString>("resumenProducto");

		///<summary>
		/// Valor producto
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		[ImplementPropertyType("valorProducto")]
		public virtual string ValorProducto => this.Value<string>("valorProducto");
	}
}