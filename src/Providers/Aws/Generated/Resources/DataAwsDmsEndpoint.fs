namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDmsEndpointState<'EndpointId> = { assignments: ResizeArray<aws.DataAwsDmsEndpoint.DataAwsDmsEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dms_endpoint">aws_dms_endpoint</a>.
    /// </summary>
    type DataAwsDmsEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDmsEndpointState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDmsEndpointState<Missing>)

        member _.Zero(()) : DataAwsDmsEndpointState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDmsEndpointState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dms_endpoint#endpoint_id-1">DataAwsDmsEndpoint#endpoint_id</a>.
        /// </summary>
        [<CustomOperation "endpoint_id">]
        member _.EndpointId(state: DataAwsDmsEndpointState<Missing>, value: string) : DataAwsDmsEndpointState<Present> =
            state.assignments.Add(fun config -> config.EndpointId <- value)
            ({ assignments = state.assignments } : DataAwsDmsEndpointState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dms_endpoint#id-1">DataAwsDmsEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDmsEndpointState<'EndpointId>, value: string) : DataAwsDmsEndpointState<'EndpointId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsDmsEndpointState<'EndpointId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dms_endpoint#tags-1">DataAwsDmsEndpoint#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsDmsEndpointState<'EndpointId>, value: seq<string * string>) : DataAwsDmsEndpointState<'EndpointId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsDmsEndpointState<'EndpointId>

        member _.Run(state: DataAwsDmsEndpointState<Present>) : aws.DataAwsDmsEndpoint.DataAwsDmsEndpoint =
            let config = aws.DataAwsDmsEndpoint.DataAwsDmsEndpointConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDmsEndpoint.DataAwsDmsEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsDmsEndpoint: missing required arguments. Must call: endpoint_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsDmsEndpointState<_>) : aws.DataAwsDmsEndpoint.DataAwsDmsEndpoint =
            Unchecked.defaultof<aws.DataAwsDmsEndpoint.DataAwsDmsEndpoint>
