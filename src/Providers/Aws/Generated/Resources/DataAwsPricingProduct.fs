namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsPricingProductState<'Filters, 'ServiceCode> = { assignments: ResizeArray<aws.DataAwsPricingProduct.DataAwsPricingProductConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/pricing_product">aws_pricing_product</a>.
    /// </summary>
    type DataAwsPricingProductBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsPricingProductState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsPricingProductState<Missing, Missing>)

        member _.Zero(()) : DataAwsPricingProductState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsPricingProductState<Missing, Missing>)

        /// <summary>
        /// filters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/pricing_product#filters-1">DataAwsPricingProduct#filters</a> Accepts: aws.IResolvable | aws.DataAwsPricingProduct.DataAwsPricingProductFilters[]
        /// </summary>
        [<CustomOperation "filters">]
        member _.Filters(state: DataAwsPricingProductState<Missing, 'ServiceCode>, value: HashiCorp.Cdktf.IResolvable) : DataAwsPricingProductState<Present, 'ServiceCode> =
            state.assignments.Add(fun config -> config.Filters <- value)
            ({ assignments = state.assignments } : DataAwsPricingProductState<Present, 'ServiceCode>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/pricing_product#service_code-1">DataAwsPricingProduct#service_code</a>.
        /// </summary>
        [<CustomOperation "service_code">]
        member _.ServiceCode(state: DataAwsPricingProductState<'Filters, Missing>, value: string) : DataAwsPricingProductState<'Filters, Present> =
            state.assignments.Add(fun config -> config.ServiceCode <- value)
            ({ assignments = state.assignments } : DataAwsPricingProductState<'Filters, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/pricing_product#id-1">DataAwsPricingProduct#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsPricingProductState<'Filters, 'ServiceCode>, value: string) : DataAwsPricingProductState<'Filters, 'ServiceCode> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsPricingProductState<'Filters, 'ServiceCode>

        member _.Run(state: DataAwsPricingProductState<Present, Present>) : aws.DataAwsPricingProduct.DataAwsPricingProduct =
            let config = aws.DataAwsPricingProduct.DataAwsPricingProductConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsPricingProduct.DataAwsPricingProduct(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsPricingProduct: missing required arguments. Must call: filters, service_code.", 9999, IsError = true)>]
        member _.Run(_: DataAwsPricingProductState<_, _>) : aws.DataAwsPricingProduct.DataAwsPricingProduct =
            Unchecked.defaultof<aws.DataAwsPricingProduct.DataAwsPricingProduct>
