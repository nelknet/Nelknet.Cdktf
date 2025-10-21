namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsMemorydbUserState<'UserName> = { assignments: ResizeArray<aws.DataAwsMemorydbUser.DataAwsMemorydbUserConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/memorydb_user">aws_memorydb_user</a>.
    /// </summary>
    type DataAwsMemorydbUserBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsMemorydbUserState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMemorydbUserState<Missing>)

        member _.Zero(()) : DataAwsMemorydbUserState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMemorydbUserState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/memorydb_user#user_name-1">DataAwsMemorydbUser#user_name</a>.
        /// </summary>
        [<CustomOperation "user_name">]
        member _.UserName(state: DataAwsMemorydbUserState<Missing>, value: string) : DataAwsMemorydbUserState<Present> =
            state.assignments.Add(fun config -> config.UserName <- value)
            ({ assignments = state.assignments } : DataAwsMemorydbUserState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/memorydb_user#id-1">DataAwsMemorydbUser#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsMemorydbUserState<'UserName>, value: string) : DataAwsMemorydbUserState<'UserName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsMemorydbUserState<'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/memorydb_user#tags-1">DataAwsMemorydbUser#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsMemorydbUserState<'UserName>, value: seq<string * string>) : DataAwsMemorydbUserState<'UserName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsMemorydbUserState<'UserName>

        member _.Run(state: DataAwsMemorydbUserState<Present>) : aws.DataAwsMemorydbUser.DataAwsMemorydbUser =
            let config = aws.DataAwsMemorydbUser.DataAwsMemorydbUserConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsMemorydbUser.DataAwsMemorydbUser(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsMemorydbUser: missing required arguments. Must call: user_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsMemorydbUserState<_>) : aws.DataAwsMemorydbUser.DataAwsMemorydbUser =
            Unchecked.defaultof<aws.DataAwsMemorydbUser.DataAwsMemorydbUser>
