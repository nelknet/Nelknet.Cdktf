namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MemorydbAclState = { assignments: ResizeArray<aws.MemorydbAcl.MemorydbAclConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_acl">aws_memorydb_acl</a>.
    /// </summary>
    type MemorydbAclBuilder(logicalId: string) =
        member _.Yield(_: unit) : MemorydbAclState =
            { assignments = ResizeArray() }

        member _.Zero(()) : MemorydbAclState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_acl#id-1">MemorydbAcl#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MemorydbAclState, value: string) : MemorydbAclState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MemorydbAclState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_acl#name-1">MemorydbAcl#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MemorydbAclState, value: string) : MemorydbAclState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : MemorydbAclState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_acl#name_prefix-1">MemorydbAcl#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: MemorydbAclState, value: string) : MemorydbAclState =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : MemorydbAclState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_acl#tags-1">MemorydbAcl#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MemorydbAclState, value: seq<string * string>) : MemorydbAclState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MemorydbAclState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_acl#tags_all-1">MemorydbAcl#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: MemorydbAclState, value: seq<string * string>) : MemorydbAclState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : MemorydbAclState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_acl#user_names-1">MemorydbAcl#user_names</a>.
        /// </summary>
        [<CustomOperation "user_names">]
        member _.UserNames(state: MemorydbAclState, value: seq<string>) : MemorydbAclState =
            state.assignments.Add(fun config -> config.UserNames <- (value |> Seq.toArray))
            state : MemorydbAclState

        member _.Run(state: MemorydbAclState) : aws.MemorydbAcl.MemorydbAcl =
            let config = aws.MemorydbAcl.MemorydbAclConfig()
            for setter in state.assignments do
                setter config
            aws.MemorydbAcl.MemorydbAcl(StackContext.get (), logicalId, config)
