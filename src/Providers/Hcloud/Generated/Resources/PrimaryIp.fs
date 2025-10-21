namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PrimaryIpState<'AssigneeType, 'AutoDelete, 'Type> = { assignments: ResizeArray<hcloud.PrimaryIp.PrimaryIpConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/primary_ip">hcloud_primary_ip</a>.
    /// </summary>
    type PrimaryIpBuilder(logicalId: string) =
        member _.Yield(_: unit) : PrimaryIpState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrimaryIpState<Missing, Missing, Missing>)

        member _.Zero(()) : PrimaryIpState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrimaryIpState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/primary_ip#assignee_type-1">PrimaryIp#assignee_type</a>.
        /// </summary>
        [<CustomOperation "assignee_type">]
        member _.AssigneeType(state: PrimaryIpState<Missing, 'AutoDelete, 'Type>, value: string) : PrimaryIpState<Present, 'AutoDelete, 'Type> =
            state.assignments.Add(fun config -> config.AssigneeType <- value)
            ({ assignments = state.assignments } : PrimaryIpState<Present, 'AutoDelete, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/primary_ip#auto_delete-1">PrimaryIp#auto_delete</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "auto_delete">]
        member _.AutoDelete(state: PrimaryIpState<'AssigneeType, Missing, 'Type>, value: bool) : PrimaryIpState<'AssigneeType, Present, 'Type> =
            state.assignments.Add(fun config -> config.AutoDelete <- value)
            ({ assignments = state.assignments } : PrimaryIpState<'AssigneeType, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/primary_ip#auto_delete-1">PrimaryIp#auto_delete</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "auto_delete">]
        member _.AutoDelete(state: PrimaryIpState<'AssigneeType, Missing, 'Type>, value: HashiCorp.Cdktf.IResolvable) : PrimaryIpState<'AssigneeType, Present, 'Type> =
            state.assignments.Add(fun config -> config.AutoDelete <- value)
            ({ assignments = state.assignments } : PrimaryIpState<'AssigneeType, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/primary_ip#type-1">PrimaryIp#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: PrimaryIpState<'AssigneeType, 'AutoDelete, Missing>, value: string) : PrimaryIpState<'AssigneeType, 'AutoDelete, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : PrimaryIpState<'AssigneeType, 'AutoDelete, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/primary_ip#assignee_id-1">PrimaryIp#assignee_id</a>.
        /// </summary>
        [<CustomOperation "assignee_id">]
        member _.AssigneeId(state: PrimaryIpState<'AssigneeType, 'AutoDelete, 'Type>, value: double) : PrimaryIpState<'AssigneeType, 'AutoDelete, 'Type> =
            state.assignments.Add(fun config -> config.AssigneeId <- value)
            state : PrimaryIpState<'AssigneeType, 'AutoDelete, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/primary_ip#datacenter-1">PrimaryIp#datacenter</a>.
        /// </summary>
        [<CustomOperation "datacenter">]
        member _.Datacenter(state: PrimaryIpState<'AssigneeType, 'AutoDelete, 'Type>, value: string) : PrimaryIpState<'AssigneeType, 'AutoDelete, 'Type> =
            state.assignments.Add(fun config -> config.Datacenter <- value)
            state : PrimaryIpState<'AssigneeType, 'AutoDelete, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/primary_ip#delete_protection-1">PrimaryIp#delete_protection</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection(state: PrimaryIpState<'AssigneeType, 'AutoDelete, 'Type>, value: bool) : PrimaryIpState<'AssigneeType, 'AutoDelete, 'Type> =
            state.assignments.Add(fun config -> config.DeleteProtection <- value)
            state : PrimaryIpState<'AssigneeType, 'AutoDelete, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/primary_ip#delete_protection-1">PrimaryIp#delete_protection</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection(state: PrimaryIpState<'AssigneeType, 'AutoDelete, 'Type>, value: HashiCorp.Cdktf.IResolvable) : PrimaryIpState<'AssigneeType, 'AutoDelete, 'Type> =
            state.assignments.Add(fun config -> config.DeleteProtection <- value)
            state : PrimaryIpState<'AssigneeType, 'AutoDelete, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/primary_ip#id-1">PrimaryIp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PrimaryIpState<'AssigneeType, 'AutoDelete, 'Type>, value: string) : PrimaryIpState<'AssigneeType, 'AutoDelete, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PrimaryIpState<'AssigneeType, 'AutoDelete, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/primary_ip#labels-1">PrimaryIp#labels</a>.
        /// </summary>
        [<CustomOperation "labels">]
        member _.Labels(state: PrimaryIpState<'AssigneeType, 'AutoDelete, 'Type>, value: seq<string * string>) : PrimaryIpState<'AssigneeType, 'AutoDelete, 'Type> =
            state.assignments.Add(fun config -> config.Labels <- dict value)
            state : PrimaryIpState<'AssigneeType, 'AutoDelete, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/primary_ip#name-1">PrimaryIp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PrimaryIpState<'AssigneeType, 'AutoDelete, 'Type>, value: string) : PrimaryIpState<'AssigneeType, 'AutoDelete, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : PrimaryIpState<'AssigneeType, 'AutoDelete, 'Type>

        member _.Run(state: PrimaryIpState<Present, Present, Present>) : hcloud.PrimaryIp.PrimaryIp =
            let config = hcloud.PrimaryIp.PrimaryIpConfig()
            for setter in state.assignments do
                setter config
            hcloud.PrimaryIp.PrimaryIp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.primaryIp: missing required arguments. Must call: assignee_type, auto_delete, type.", 9999, IsError = true)>]
        member _.Run(_: PrimaryIpState<_, _, _>) : hcloud.PrimaryIp.PrimaryIp =
            Unchecked.defaultof<hcloud.PrimaryIp.PrimaryIp>
