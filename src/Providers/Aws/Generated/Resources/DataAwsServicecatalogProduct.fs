namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsServicecatalogProductState<'Id> = { assignments: ResizeArray<aws.DataAwsServicecatalogProduct.DataAwsServicecatalogProductConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_product">aws_servicecatalog_product</a>.
    /// </summary>
    type DataAwsServicecatalogProductBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsServicecatalogProductState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServicecatalogProductState<Missing>)

        member _.Zero(()) : DataAwsServicecatalogProductState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServicecatalogProductState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_product#id-1">DataAwsServicecatalogProduct#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsServicecatalogProductState<Missing>, value: string) : DataAwsServicecatalogProductState<Present> =
            state.assignments.Add(fun config -> config.Id <- value)
            ({ assignments = state.assignments } : DataAwsServicecatalogProductState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_product#accept_language-1">DataAwsServicecatalogProduct#accept_language</a>.
        /// </summary>
        [<CustomOperation "accept_language">]
        member _.AcceptLanguage(state: DataAwsServicecatalogProductState<'Id>, value: string) : DataAwsServicecatalogProductState<'Id> =
            state.assignments.Add(fun config -> config.AcceptLanguage <- value)
            state : DataAwsServicecatalogProductState<'Id>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_product#tags-1">DataAwsServicecatalogProduct#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsServicecatalogProductState<'Id>, value: seq<string * string>) : DataAwsServicecatalogProductState<'Id> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsServicecatalogProductState<'Id>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_product#timeouts-1">DataAwsServicecatalogProduct#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsServicecatalogProductState<'Id>, value: aws.DataAwsServicecatalogProduct.DataAwsServicecatalogProductTimeouts) : DataAwsServicecatalogProductState<'Id> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsServicecatalogProductState<'Id>

        member _.Run(state: DataAwsServicecatalogProductState<Present>) : aws.DataAwsServicecatalogProduct.DataAwsServicecatalogProduct =
            let config = aws.DataAwsServicecatalogProduct.DataAwsServicecatalogProductConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsServicecatalogProduct.DataAwsServicecatalogProduct(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsServicecatalogProduct: missing required arguments. Must call: id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsServicecatalogProductState<_>) : aws.DataAwsServicecatalogProduct.DataAwsServicecatalogProduct =
            Unchecked.defaultof<aws.DataAwsServicecatalogProduct.DataAwsServicecatalogProduct>
