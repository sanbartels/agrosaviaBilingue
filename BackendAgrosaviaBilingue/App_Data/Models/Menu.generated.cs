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
	// Mixin Content Type with alias "menu"
	/// <summary>Menu</summary>
	public partial interface IMenu : IPublishedElement
	{
		/// <summary>MostrarEnMenu</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		bool MostrarEnMenu { get; }

		/// <summary>Titulo</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		string Titulo { get; }
	}

	/// <summary>Menu</summary>
	[PublishedModel("menu")]
	public partial class Menu : PublishedElementModel, IMenu
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		public new const string ModelTypeAlias = "menu";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Menu, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Menu(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// MostrarEnMenu
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		[ImplementPropertyType("mostrarEnMenu")]
		public virtual bool MostrarEnMenu => GetMostrarEnMenu(this);

		/// <summary>Static getter for MostrarEnMenu</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		public static bool GetMostrarEnMenu(IMenu that) => that.Value<bool>("mostrarEnMenu");

		///<summary>
		/// Titulo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		[ImplementPropertyType("titulo")]
		public virtual string Titulo => GetTitulo(this);

		/// <summary>Static getter for Titulo</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.0")]
		public static string GetTitulo(IMenu that) => that.Value<string>("titulo");
	}
}