namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsVpclatticeServiceState = { assignments: ResizeArray<aws.DataAwsVpclatticeService.DataAwsVpclatticeServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpclattice_service">aws_vpclattice_service</a>.
    /// </summary>
    type DataAwsVpclatticeServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsVpclatticeServiceState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsVpclatticeServiceState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpclattice_service#id-1">DataAwsVpclatticeService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsVpclatticeServiceState, value: string) : DataAwsVpclatticeServiceState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsVpclatticeServiceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpclattice_service#name-1">DataAwsVpclatticeService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsVpclatticeServiceState, value: string) : DataAwsVpclatticeServiceState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsVpclatticeServiceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpclattice_service#service_identifier-1">DataAwsVpclatticeService#service_identifier</a>.
        /// </summary>
        [<CustomOperation "service_identifier">]
        member _.ServiceIdentifier(state: DataAwsVpclatticeServiceState, value: string) : DataAwsVpclatticeServiceState =
            state.assignments.Add(fun config -> config.ServiceIdentifier <- value)
            state : DataAwsVpclatticeServiceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpclattice_service#tags-1">DataAwsVpclatticeService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsVpclatticeServiceState, value: seq<string * string>) : DataAwsVpclatticeServiceState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsVpclatticeServiceState

        member _.Run(state: DataAwsVpclatticeServiceState) : aws.DataAwsVpclatticeService.DataAwsVpclatticeService =
            let config = aws.DataAwsVpclatticeService.DataAwsVpclatticeServiceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsVpclatticeService.DataAwsVpclatticeService(StackContext.get (), logicalId, config)
