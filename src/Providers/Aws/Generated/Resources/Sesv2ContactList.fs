namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Sesv2ContactListState<'ContactListName> = { assignments: ResizeArray<aws.Sesv2ContactList.Sesv2ContactListConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_contact_list">aws_sesv2_contact_list</a>.
    /// </summary>
    type Sesv2ContactListBuilder(logicalId: string) =
        member _.Yield(_: unit) : Sesv2ContactListState<Missing> =
            ({ assignments = ResizeArray() } : Sesv2ContactListState<Missing>)

        member _.Zero(()) : Sesv2ContactListState<Missing> =
            ({ assignments = ResizeArray() } : Sesv2ContactListState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_contact_list#contact_list_name-1">Sesv2ContactList#contact_list_name</a>.
        /// </summary>
        [<CustomOperation "contact_list_name">]
        member _.ContactListName(state: Sesv2ContactListState<Missing>, value: string) : Sesv2ContactListState<Present> =
            state.assignments.Add(fun config -> config.ContactListName <- value)
            ({ assignments = state.assignments } : Sesv2ContactListState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_contact_list#description-1">Sesv2ContactList#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Sesv2ContactListState<'ContactListName>, value: string) : Sesv2ContactListState<'ContactListName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Sesv2ContactListState<'ContactListName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_contact_list#id-1">Sesv2ContactList#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Sesv2ContactListState<'ContactListName>, value: string) : Sesv2ContactListState<'ContactListName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Sesv2ContactListState<'ContactListName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_contact_list#tags-1">Sesv2ContactList#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Sesv2ContactListState<'ContactListName>, value: seq<string * string>) : Sesv2ContactListState<'ContactListName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Sesv2ContactListState<'ContactListName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_contact_list#tags_all-1">Sesv2ContactList#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Sesv2ContactListState<'ContactListName>, value: seq<string * string>) : Sesv2ContactListState<'ContactListName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Sesv2ContactListState<'ContactListName>

        /// <summary>
        /// topic block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_contact_list#topic-1">Sesv2ContactList#topic</a> Accepts: aws.IResolvable | aws.Sesv2ContactList.Sesv2ContactListTopic[]
        /// </summary>
        [<CustomOperation "topic">]
        member _.Topic(state: Sesv2ContactListState<'ContactListName>, value: HashiCorp.Cdktf.IResolvable) : Sesv2ContactListState<'ContactListName> =
            state.assignments.Add(fun config -> config.Topic <- value)
            state : Sesv2ContactListState<'ContactListName>

        member _.Run(state: Sesv2ContactListState<Present>) : aws.Sesv2ContactList.Sesv2ContactList =
            let config = aws.Sesv2ContactList.Sesv2ContactListConfig()
            for setter in state.assignments do
                setter config
            aws.Sesv2ContactList.Sesv2ContactList(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sesv2ContactList: missing required arguments. Must call: contact_list_name.", 9999, IsError = true)>]
        member _.Run(_: Sesv2ContactListState<_>) : aws.Sesv2ContactList.Sesv2ContactList =
            Unchecked.defaultof<aws.Sesv2ContactList.Sesv2ContactList>
