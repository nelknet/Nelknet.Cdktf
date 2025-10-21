namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsMemorydbAclState<'Name> = { assignments: ResizeArray<aws.DataAwsMemorydbAcl.DataAwsMemorydbAclConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/memorydb_acl">aws_memorydb_acl</a>.
    /// </summary>
    type DataAwsMemorydbAclBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsMemorydbAclState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMemorydbAclState<Missing>)

        member _.Zero(()) : DataAwsMemorydbAclState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMemorydbAclState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/memorydb_acl#name-1">DataAwsMemorydbAcl#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsMemorydbAclState<Missing>, value: string) : DataAwsMemorydbAclState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsMemorydbAclState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/memorydb_acl#id-1">DataAwsMemorydbAcl#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsMemorydbAclState<'Name>, value: string) : DataAwsMemorydbAclState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsMemorydbAclState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/memorydb_acl#tags-1">DataAwsMemorydbAcl#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsMemorydbAclState<'Name>, value: seq<string * string>) : DataAwsMemorydbAclState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsMemorydbAclState<'Name>

        member _.Run(state: DataAwsMemorydbAclState<Present>) : aws.DataAwsMemorydbAcl.DataAwsMemorydbAcl =
            let config = aws.DataAwsMemorydbAcl.DataAwsMemorydbAclConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsMemorydbAcl.DataAwsMemorydbAcl(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsMemorydbAcl: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsMemorydbAclState<_>) : aws.DataAwsMemorydbAcl.DataAwsMemorydbAcl =
            Unchecked.defaultof<aws.DataAwsMemorydbAcl.DataAwsMemorydbAcl>
