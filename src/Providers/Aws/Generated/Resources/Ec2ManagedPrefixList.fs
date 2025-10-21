namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2ManagedPrefixListState<'AddressFamily, 'MaxEntries, 'Name> = { assignments: ResizeArray<aws.Ec2ManagedPrefixList.Ec2ManagedPrefixListConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_managed_prefix_list">aws_ec2_managed_prefix_list</a>.
    /// </summary>
    type Ec2ManagedPrefixListBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2ManagedPrefixListState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2ManagedPrefixListState<Missing, Missing, Missing>)

        member _.Zero(()) : Ec2ManagedPrefixListState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2ManagedPrefixListState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_managed_prefix_list#address_family-1">Ec2ManagedPrefixList#address_family</a>.
        /// </summary>
        [<CustomOperation "address_family">]
        member _.AddressFamily(state: Ec2ManagedPrefixListState<Missing, 'MaxEntries, 'Name>, value: string) : Ec2ManagedPrefixListState<Present, 'MaxEntries, 'Name> =
            state.assignments.Add(fun config -> config.AddressFamily <- value)
            ({ assignments = state.assignments } : Ec2ManagedPrefixListState<Present, 'MaxEntries, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_managed_prefix_list#max_entries-1">Ec2ManagedPrefixList#max_entries</a>.
        /// </summary>
        [<CustomOperation "max_entries">]
        member _.MaxEntries(state: Ec2ManagedPrefixListState<'AddressFamily, Missing, 'Name>, value: double) : Ec2ManagedPrefixListState<'AddressFamily, Present, 'Name> =
            state.assignments.Add(fun config -> config.MaxEntries <- value)
            ({ assignments = state.assignments } : Ec2ManagedPrefixListState<'AddressFamily, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_managed_prefix_list#name-1">Ec2ManagedPrefixList#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Ec2ManagedPrefixListState<'AddressFamily, 'MaxEntries, Missing>, value: string) : Ec2ManagedPrefixListState<'AddressFamily, 'MaxEntries, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Ec2ManagedPrefixListState<'AddressFamily, 'MaxEntries, Present>)

        /// <summary>
        /// entry block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_managed_prefix_list#entry-1">Ec2ManagedPrefixList#entry</a> Accepts: aws.IResolvable | aws.Ec2ManagedPrefixList.Ec2ManagedPrefixListEntry[]
        /// </summary>
        [<CustomOperation "entry">]
        member _.Entry(state: Ec2ManagedPrefixListState<'AddressFamily, 'MaxEntries, 'Name>, value: HashiCorp.Cdktf.IResolvable) : Ec2ManagedPrefixListState<'AddressFamily, 'MaxEntries, 'Name> =
            state.assignments.Add(fun config -> config.Entry <- value)
            state : Ec2ManagedPrefixListState<'AddressFamily, 'MaxEntries, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_managed_prefix_list#id-1">Ec2ManagedPrefixList#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2ManagedPrefixListState<'AddressFamily, 'MaxEntries, 'Name>, value: string) : Ec2ManagedPrefixListState<'AddressFamily, 'MaxEntries, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2ManagedPrefixListState<'AddressFamily, 'MaxEntries, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_managed_prefix_list#tags-1">Ec2ManagedPrefixList#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Ec2ManagedPrefixListState<'AddressFamily, 'MaxEntries, 'Name>, value: seq<string * string>) : Ec2ManagedPrefixListState<'AddressFamily, 'MaxEntries, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Ec2ManagedPrefixListState<'AddressFamily, 'MaxEntries, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_managed_prefix_list#tags_all-1">Ec2ManagedPrefixList#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Ec2ManagedPrefixListState<'AddressFamily, 'MaxEntries, 'Name>, value: seq<string * string>) : Ec2ManagedPrefixListState<'AddressFamily, 'MaxEntries, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Ec2ManagedPrefixListState<'AddressFamily, 'MaxEntries, 'Name>

        member _.Run(state: Ec2ManagedPrefixListState<Present, Present, Present>) : aws.Ec2ManagedPrefixList.Ec2ManagedPrefixList =
            let config = aws.Ec2ManagedPrefixList.Ec2ManagedPrefixListConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2ManagedPrefixList.Ec2ManagedPrefixList(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2ManagedPrefixList: missing required arguments. Must call: address_family, max_entries, name.", 9999, IsError = true)>]
        member _.Run(_: Ec2ManagedPrefixListState<_, _, _>) : aws.Ec2ManagedPrefixList.Ec2ManagedPrefixList =
            Unchecked.defaultof<aws.Ec2ManagedPrefixList.Ec2ManagedPrefixList>
