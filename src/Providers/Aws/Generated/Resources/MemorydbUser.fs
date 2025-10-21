namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MemorydbUserState<'AccessString, 'AuthenticationMode, 'UserName> = { assignments: ResizeArray<aws.MemorydbUser.MemorydbUserConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_user">aws_memorydb_user</a>.
    /// </summary>
    type MemorydbUserBuilder(logicalId: string) =
        member _.Yield(_: unit) : MemorydbUserState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MemorydbUserState<Missing, Missing, Missing>)

        member _.Zero(()) : MemorydbUserState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MemorydbUserState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_user#access_string-1">MemorydbUser#access_string</a>.
        /// </summary>
        [<CustomOperation "access_string">]
        member _.AccessString(state: MemorydbUserState<Missing, 'AuthenticationMode, 'UserName>, value: string) : MemorydbUserState<Present, 'AuthenticationMode, 'UserName> =
            state.assignments.Add(fun config -> config.AccessString <- value)
            ({ assignments = state.assignments } : MemorydbUserState<Present, 'AuthenticationMode, 'UserName>)

        /// <summary>
        /// authentication_mode block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_user#authentication_mode-1">MemorydbUser#authentication_mode</a>
        /// </summary>
        [<CustomOperation "authentication_mode">]
        member _.AuthenticationMode(state: MemorydbUserState<'AccessString, Missing, 'UserName>, value: aws.MemorydbUser.MemorydbUserAuthenticationMode) : MemorydbUserState<'AccessString, Present, 'UserName> =
            state.assignments.Add(fun config -> config.AuthenticationMode <- value)
            ({ assignments = state.assignments } : MemorydbUserState<'AccessString, Present, 'UserName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_user#user_name-1">MemorydbUser#user_name</a>.
        /// </summary>
        [<CustomOperation "user_name">]
        member _.UserName(state: MemorydbUserState<'AccessString, 'AuthenticationMode, Missing>, value: string) : MemorydbUserState<'AccessString, 'AuthenticationMode, Present> =
            state.assignments.Add(fun config -> config.UserName <- value)
            ({ assignments = state.assignments } : MemorydbUserState<'AccessString, 'AuthenticationMode, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_user#id-1">MemorydbUser#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MemorydbUserState<'AccessString, 'AuthenticationMode, 'UserName>, value: string) : MemorydbUserState<'AccessString, 'AuthenticationMode, 'UserName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MemorydbUserState<'AccessString, 'AuthenticationMode, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_user#tags-1">MemorydbUser#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MemorydbUserState<'AccessString, 'AuthenticationMode, 'UserName>, value: seq<string * string>) : MemorydbUserState<'AccessString, 'AuthenticationMode, 'UserName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MemorydbUserState<'AccessString, 'AuthenticationMode, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_user#tags_all-1">MemorydbUser#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: MemorydbUserState<'AccessString, 'AuthenticationMode, 'UserName>, value: seq<string * string>) : MemorydbUserState<'AccessString, 'AuthenticationMode, 'UserName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : MemorydbUserState<'AccessString, 'AuthenticationMode, 'UserName>

        member _.Run(state: MemorydbUserState<Present, Present, Present>) : aws.MemorydbUser.MemorydbUser =
            let config = aws.MemorydbUser.MemorydbUserConfig()
            for setter in state.assignments do
                setter config
            aws.MemorydbUser.MemorydbUser(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.memorydbUser: missing required arguments. Must call: access_string, authentication_mode, user_name.", 9999, IsError = true)>]
        member _.Run(_: MemorydbUserState<_, _, _>) : aws.MemorydbUser.MemorydbUser =
            Unchecked.defaultof<aws.MemorydbUser.MemorydbUser>
