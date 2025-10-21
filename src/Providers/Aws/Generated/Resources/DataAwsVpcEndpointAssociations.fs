namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsVpcEndpointAssociationsState<'VpcEndpointId> = { assignments: ResizeArray<aws.DataAwsVpcEndpointAssociations.DataAwsVpcEndpointAssociationsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_endpoint_associations">aws_vpc_endpoint_associations</a>.
    /// </summary>
    type DataAwsVpcEndpointAssociationsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsVpcEndpointAssociationsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsVpcEndpointAssociationsState<Missing>)

        member _.Zero(()) : DataAwsVpcEndpointAssociationsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsVpcEndpointAssociationsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_endpoint_associations#vpc_endpoint_id-1">DataAwsVpcEndpointAssociations#vpc_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "vpc_endpoint_id">]
        member _.VpcEndpointId(state: DataAwsVpcEndpointAssociationsState<Missing>, value: string) : DataAwsVpcEndpointAssociationsState<Present> =
            state.assignments.Add(fun config -> config.VpcEndpointId <- value)
            ({ assignments = state.assignments } : DataAwsVpcEndpointAssociationsState<Present>)

        member _.Run(state: DataAwsVpcEndpointAssociationsState<Present>) : aws.DataAwsVpcEndpointAssociations.DataAwsVpcEndpointAssociations =
            let config = aws.DataAwsVpcEndpointAssociations.DataAwsVpcEndpointAssociationsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsVpcEndpointAssociations.DataAwsVpcEndpointAssociations(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsVpcEndpointAssociations: missing required arguments. Must call: vpc_endpoint_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsVpcEndpointAssociationsState<_>) : aws.DataAwsVpcEndpointAssociations.DataAwsVpcEndpointAssociations =
            Unchecked.defaultof<aws.DataAwsVpcEndpointAssociations.DataAwsVpcEndpointAssociations>
