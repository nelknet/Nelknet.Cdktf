namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2ManagedPrefixListEntryAState<'Cidr, 'PrefixListId> = { assignments: ResizeArray<aws.Ec2ManagedPrefixListEntry.Ec2ManagedPrefixListEntryAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_managed_prefix_list_entry">aws_ec2_managed_prefix_list_entry</a>.
    /// </summary>
    type Ec2ManagedPrefixListEntryABuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2ManagedPrefixListEntryAState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2ManagedPrefixListEntryAState<Missing, Missing>)

        member _.Zero(()) : Ec2ManagedPrefixListEntryAState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2ManagedPrefixListEntryAState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_managed_prefix_list_entry#cidr-1">Ec2ManagedPrefixListEntryA#cidr</a>.
        /// </summary>
        [<CustomOperation "cidr">]
        member _.Cidr(state: Ec2ManagedPrefixListEntryAState<Missing, 'PrefixListId>, value: string) : Ec2ManagedPrefixListEntryAState<Present, 'PrefixListId> =
            state.assignments.Add(fun config -> config.Cidr <- value)
            ({ assignments = state.assignments } : Ec2ManagedPrefixListEntryAState<Present, 'PrefixListId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_managed_prefix_list_entry#prefix_list_id-1">Ec2ManagedPrefixListEntryA#prefix_list_id</a>.
        /// </summary>
        [<CustomOperation "prefix_list_id">]
        member _.PrefixListId(state: Ec2ManagedPrefixListEntryAState<'Cidr, Missing>, value: string) : Ec2ManagedPrefixListEntryAState<'Cidr, Present> =
            state.assignments.Add(fun config -> config.PrefixListId <- value)
            ({ assignments = state.assignments } : Ec2ManagedPrefixListEntryAState<'Cidr, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_managed_prefix_list_entry#description-1">Ec2ManagedPrefixListEntryA#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Ec2ManagedPrefixListEntryAState<'Cidr, 'PrefixListId>, value: string) : Ec2ManagedPrefixListEntryAState<'Cidr, 'PrefixListId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Ec2ManagedPrefixListEntryAState<'Cidr, 'PrefixListId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_managed_prefix_list_entry#id-1">Ec2ManagedPrefixListEntryA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2ManagedPrefixListEntryAState<'Cidr, 'PrefixListId>, value: string) : Ec2ManagedPrefixListEntryAState<'Cidr, 'PrefixListId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2ManagedPrefixListEntryAState<'Cidr, 'PrefixListId>

        member _.Run(state: Ec2ManagedPrefixListEntryAState<Present, Present>) : aws.Ec2ManagedPrefixListEntry.Ec2ManagedPrefixListEntryA =
            let config = aws.Ec2ManagedPrefixListEntry.Ec2ManagedPrefixListEntryAConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2ManagedPrefixListEntry.Ec2ManagedPrefixListEntryA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2ManagedPrefixListEntryA: missing required arguments. Must call: cidr, prefix_list_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2ManagedPrefixListEntryAState<_, _>) : aws.Ec2ManagedPrefixListEntry.Ec2ManagedPrefixListEntryA =
            Unchecked.defaultof<aws.Ec2ManagedPrefixListEntry.Ec2ManagedPrefixListEntryA>
