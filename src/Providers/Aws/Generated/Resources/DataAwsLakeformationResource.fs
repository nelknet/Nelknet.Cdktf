namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLakeformationResourceState<'Arn> = { assignments: ResizeArray<aws.DataAwsLakeformationResource.DataAwsLakeformationResourceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_resource">aws_lakeformation_resource</a>.
    /// </summary>
    type DataAwsLakeformationResourceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLakeformationResourceState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLakeformationResourceState<Missing>)

        member _.Zero(()) : DataAwsLakeformationResourceState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLakeformationResourceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_resource#arn-1">DataAwsLakeformationResource#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsLakeformationResourceState<Missing>, value: string) : DataAwsLakeformationResourceState<Present> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : DataAwsLakeformationResourceState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_resource#id-1">DataAwsLakeformationResource#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLakeformationResourceState<'Arn>, value: string) : DataAwsLakeformationResourceState<'Arn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLakeformationResourceState<'Arn>

        member _.Run(state: DataAwsLakeformationResourceState<Present>) : aws.DataAwsLakeformationResource.DataAwsLakeformationResource =
            let config = aws.DataAwsLakeformationResource.DataAwsLakeformationResourceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLakeformationResource.DataAwsLakeformationResource(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsLakeformationResource: missing required arguments. Must call: arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsLakeformationResourceState<_>) : aws.DataAwsLakeformationResource.DataAwsLakeformationResource =
            Unchecked.defaultof<aws.DataAwsLakeformationResource.DataAwsLakeformationResource>
