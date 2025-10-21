namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KubernetesFleetMemberState<'KubernetesClusterId, 'KubernetesFleetId, 'Name> = { assignments: ResizeArray<azurerm.KubernetesFleetMember.KubernetesFleetMemberConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_member">azurerm_kubernetes_fleet_member</a>.
    /// </summary>
    type KubernetesFleetMemberBuilder(logicalId: string) =
        member _.Yield(_: unit) : KubernetesFleetMemberState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KubernetesFleetMemberState<Missing, Missing, Missing>)

        member _.Zero(()) : KubernetesFleetMemberState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KubernetesFleetMemberState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_member#kubernetes_cluster_id-1">KubernetesFleetMember#kubernetes_cluster_id</a>.
        /// </summary>
        [<CustomOperation "kubernetes_cluster_id">]
        member _.KubernetesClusterId(state: KubernetesFleetMemberState<Missing, 'KubernetesFleetId, 'Name>, value: string) : KubernetesFleetMemberState<Present, 'KubernetesFleetId, 'Name> =
            state.assignments.Add(fun config -> config.KubernetesClusterId <- value)
            ({ assignments = state.assignments } : KubernetesFleetMemberState<Present, 'KubernetesFleetId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_member#kubernetes_fleet_id-1">KubernetesFleetMember#kubernetes_fleet_id</a>.
        /// </summary>
        [<CustomOperation "kubernetes_fleet_id">]
        member _.KubernetesFleetId(state: KubernetesFleetMemberState<'KubernetesClusterId, Missing, 'Name>, value: string) : KubernetesFleetMemberState<'KubernetesClusterId, Present, 'Name> =
            state.assignments.Add(fun config -> config.KubernetesFleetId <- value)
            ({ assignments = state.assignments } : KubernetesFleetMemberState<'KubernetesClusterId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_member#name-1">KubernetesFleetMember#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KubernetesFleetMemberState<'KubernetesClusterId, 'KubernetesFleetId, Missing>, value: string) : KubernetesFleetMemberState<'KubernetesClusterId, 'KubernetesFleetId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KubernetesFleetMemberState<'KubernetesClusterId, 'KubernetesFleetId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_member#group-1">KubernetesFleetMember#group</a>.
        /// </summary>
        [<CustomOperation "group">]
        member _.Group(state: KubernetesFleetMemberState<'KubernetesClusterId, 'KubernetesFleetId, 'Name>, value: string) : KubernetesFleetMemberState<'KubernetesClusterId, 'KubernetesFleetId, 'Name> =
            state.assignments.Add(fun config -> config.Group <- value)
            state : KubernetesFleetMemberState<'KubernetesClusterId, 'KubernetesFleetId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_member#id-1">KubernetesFleetMember#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KubernetesFleetMemberState<'KubernetesClusterId, 'KubernetesFleetId, 'Name>, value: string) : KubernetesFleetMemberState<'KubernetesClusterId, 'KubernetesFleetId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KubernetesFleetMemberState<'KubernetesClusterId, 'KubernetesFleetId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_member#timeouts-1">KubernetesFleetMember#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KubernetesFleetMemberState<'KubernetesClusterId, 'KubernetesFleetId, 'Name>, value: azurerm.KubernetesFleetMember.KubernetesFleetMemberTimeouts) : KubernetesFleetMemberState<'KubernetesClusterId, 'KubernetesFleetId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KubernetesFleetMemberState<'KubernetesClusterId, 'KubernetesFleetId, 'Name>

        member _.Run(state: KubernetesFleetMemberState<Present, Present, Present>) : azurerm.KubernetesFleetMember.KubernetesFleetMember =
            let config = azurerm.KubernetesFleetMember.KubernetesFleetMemberConfig()
            for setter in state.assignments do
                setter config
            azurerm.KubernetesFleetMember.KubernetesFleetMember(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.kubernetesFleetMember: missing required arguments. Must call: kubernetes_cluster_id, kubernetes_fleet_id, name.", 9999, IsError = true)>]
        member _.Run(_: KubernetesFleetMemberState<_, _, _>) : azurerm.KubernetesFleetMember.KubernetesFleetMember =
            Unchecked.defaultof<azurerm.KubernetesFleetMember.KubernetesFleetMember>
