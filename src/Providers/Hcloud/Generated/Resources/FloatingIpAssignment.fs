namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FloatingIpAssignmentState<'FloatingIpId, 'ServerId> = { assignments: ResizeArray<hcloud.FloatingIpAssignment.FloatingIpAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip_assignment">hcloud_floating_ip_assignment</a>.
    /// </summary>
    type FloatingIpAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : FloatingIpAssignmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : FloatingIpAssignmentState<Missing, Missing>)

        member _.Zero(()) : FloatingIpAssignmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : FloatingIpAssignmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip_assignment#floating_ip_id-1">FloatingIpAssignment#floating_ip_id</a>.
        /// </summary>
        [<CustomOperation "floating_ip_id">]
        member _.FloatingIpId(state: FloatingIpAssignmentState<Missing, 'ServerId>, value: double) : FloatingIpAssignmentState<Present, 'ServerId> =
            state.assignments.Add(fun config -> config.FloatingIpId <- value)
            ({ assignments = state.assignments } : FloatingIpAssignmentState<Present, 'ServerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip_assignment#server_id-1">FloatingIpAssignment#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: FloatingIpAssignmentState<'FloatingIpId, Missing>, value: double) : FloatingIpAssignmentState<'FloatingIpId, Present> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            ({ assignments = state.assignments } : FloatingIpAssignmentState<'FloatingIpId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/floating_ip_assignment#id-1">FloatingIpAssignment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FloatingIpAssignmentState<'FloatingIpId, 'ServerId>, value: string) : FloatingIpAssignmentState<'FloatingIpId, 'ServerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FloatingIpAssignmentState<'FloatingIpId, 'ServerId>

        member _.Run(state: FloatingIpAssignmentState<Present, Present>) : hcloud.FloatingIpAssignment.FloatingIpAssignment =
            let config = hcloud.FloatingIpAssignment.FloatingIpAssignmentConfig()
            for setter in state.assignments do
                setter config
            hcloud.FloatingIpAssignment.FloatingIpAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.floatingIpAssignment: missing required arguments. Must call: floating_ip_id, server_id.", 9999, IsError = true)>]
        member _.Run(_: FloatingIpAssignmentState<_, _>) : hcloud.FloatingIpAssignment.FloatingIpAssignment =
            Unchecked.defaultof<hcloud.FloatingIpAssignment.FloatingIpAssignment>
