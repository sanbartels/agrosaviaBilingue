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
	/// <summary>Producto promocion</summary>
	[PublishedModel("productoPromocion")]
	public partial class ProductoPromocion : PublishedElementModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		public new const string ModelTypeAlias = "productoPromocion";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ProductoPromocion, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ProductoPromocion(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Imagen
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		[ImplementPropertyType("imagen")]
		public virtual global::Umbraco.Core.Models.MediaWithCrops Imagen => this.Value<global::Umbraco.Core.Models.MediaWithCrops>("imagen");

		///<summary>
		/// Link: Puede ser #
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		[ImplementPropertyType("link")]
		public virtual string Link => this.Value<string>("link");

		///<summary>
		/// nombre
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		[ImplementPropertyType("nombre")]
		public virtual string Nombre => this.Value<string>("nombre");

		///<summary>
		/// Texto oferta
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		[ImplementPropertyType("textoOferta")]
		public virtual string TextoOferta => this.Value<string>("textoOferta");
	}
}