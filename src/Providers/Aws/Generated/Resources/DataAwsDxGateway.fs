namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDxGatewayState<'Name> = { assignments: ResizeArray<aws.DataAwsDxGateway.DataAwsDxGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dx_gateway">aws_dx_gateway</a>.
    /// </summary>
    type DataAwsDxGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDxGatewayState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDxGatewayState<Missing>)

        member _.Zero(()) : DataAwsDxGatewayState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDxGatewayState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dx_gateway#name-1">DataAwsDxGateway#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsDxGatewayState<Missing>, value: string) : DataAwsDxGatewayState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsDxGatewayState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dx_gateway#id-1">DataAwsDxGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDxGatewayState<'Name>, value: string) : DataAwsDxGatewayState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsDxGatewayState<'Name>

        member _.Run(state: DataAwsDxGatewayState<Present>) : aws.DataAwsDxGateway.DataAwsDxGateway =
            let config = aws.DataAwsDxGateway.DataAwsDxGatewayConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDxGateway.DataAwsDxGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsDxGateway: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsDxGatewayState<_>) : aws.DataAwsDxGateway.DataAwsDxGateway =
            Unchecked.defaultof<aws.DataAwsDxGateway.DataAwsDxGateway>
