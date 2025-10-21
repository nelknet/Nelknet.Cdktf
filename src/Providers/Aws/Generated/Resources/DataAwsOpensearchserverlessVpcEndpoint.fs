namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOpensearchserverlessVpcEndpointState<'VpcEndpointId> = { assignments: ResizeArray<aws.DataAwsOpensearchserverlessVpcEndpoint.DataAwsOpensearchserverlessVpcEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/opensearchserverless_vpc_endpoint">aws_opensearchserverless_vpc_endpoint</a>.
    /// </summary>
    type DataAwsOpensearchserverlessVpcEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOpensearchserverlessVpcEndpointState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOpensearchserverlessVpcEndpointState<Missing>)

        member _.Zero(()) : DataAwsOpensearchserverlessVpcEndpointState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOpensearchserverlessVpcEndpointState<Missing>)

        /// <summary>
        /// The unique identifier of the endpoint. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/opensearchserverless_vpc_endpoint#vpc_endpoint_id-1">DataAwsOpensearchserverlessVpcEndpoint#vpc_endpoint_id</a>
        /// </summary>
        [<CustomOperation "vpc_endpoint_id">]
        member _.VpcEndpointId(state: DataAwsOpensearchserverlessVpcEndpointState<Missing>, value: string) : DataAwsOpensearchserverlessVpcEndpointState<Present> =
            state.assignments.Add(fun config -> config.VpcEndpointId <- value)
            ({ assignments = state.assignments } : DataAwsOpensearchserverlessVpcEndpointState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/opensearchserverless_vpc_endpoint#id-1">DataAwsOpensearchserverlessVpcEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsOpensearchserverlessVpcEndpointState<'VpcEndpointId>, value: string) : DataAwsOpensearchserverlessVpcEndpointState<'VpcEndpointId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsOpensearchserverlessVpcEndpointState<'VpcEndpointId>

        member _.Run(state: DataAwsOpensearchserverlessVpcEndpointState<Present>) : aws.DataAwsOpensearchserverlessVpcEndpoint.DataAwsOpensearchserverlessVpcEndpoint =
            let config = aws.DataAwsOpensearchserverlessVpcEndpoint.DataAwsOpensearchserverlessVpcEndpointConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOpensearchserverlessVpcEndpoint.DataAwsOpensearchserverlessVpcEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsOpensearchserverlessVpcEndpoint: missing required arguments. Must call: vpc_endpoint_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsOpensearchserverlessVpcEndpointState<_>) : aws.DataAwsOpensearchserverlessVpcEndpoint.DataAwsOpensearchserverlessVpcEndpoint =
            Unchecked.defaultof<aws.DataAwsOpensearchserverlessVpcEndpoint.DataAwsOpensearchserverlessVpcEndpoint>
