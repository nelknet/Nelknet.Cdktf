namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type TransferUserState<'Role, 'ServerId, 'UserName> = { assignments: ResizeArray<aws.TransferUser.TransferUserConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_user">aws_transfer_user</a>.
    /// </summary>
    type TransferUserBuilder(logicalId: string) =
        member _.Yield(_: unit) : TransferUserState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : TransferUserState<Missing, Missing, Missing>)

        member _.Zero(()) : TransferUserState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : TransferUserState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_user#role-1">TransferUser#role</a>.
        /// </summary>
        [<CustomOperation "role">]
        member _.Role(state: TransferUserState<Missing, 'ServerId, 'UserName>, value: string) : TransferUserState<Present, 'ServerId, 'UserName> =
            state.assignments.Add(fun config -> config.Role <- value)
            ({ assignments = state.assignments } : TransferUserState<Present, 'ServerId, 'UserName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_user#server_id-1">TransferUser#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: TransferUserState<'Role, Missing, 'UserName>, value: string) : TransferUserState<'Role, Present, 'UserName> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            ({ assignments = state.assignments } : TransferUserState<'Role, Present, 'UserName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_user#user_name-1">TransferUser#user_name</a>.
        /// </summary>
        [<CustomOperation "user_name">]
        member _.UserName(state: TransferUserState<'Role, 'ServerId, Missing>, value: string) : TransferUserState<'Role, 'ServerId, Present> =
            state.assignments.Add(fun config -> config.UserName <- value)
            ({ assignments = state.assignments } : TransferUserState<'Role, 'ServerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_user#home_directory-1">TransferUser#home_directory</a>.
        /// </summary>
        [<CustomOperation "home_directory">]
        member _.HomeDirectory(state: TransferUserState<'Role, 'ServerId, 'UserName>, value: string) : TransferUserState<'Role, 'ServerId, 'UserName> =
            state.assignments.Add(fun config -> config.HomeDirectory <- value)
            state : TransferUserState<'Role, 'ServerId, 'UserName>

        /// <summary>
        /// home_directory_mappings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_user#home_directory_mappings-1">TransferUser#home_directory_mappings</a> Accepts: aws.IResolvable | aws.TransferUser.TransferUserHomeDirectoryMappings[]
        /// </summary>
        [<CustomOperation "home_directory_mappings">]
        member _.HomeDirectoryMappings(state: TransferUserState<'Role, 'ServerId, 'UserName>, value: HashiCorp.Cdktf.IResolvable) : TransferUserState<'Role, 'ServerId, 'UserName> =
            state.assignments.Add(fun config -> config.HomeDirectoryMappings <- value)
            state : TransferUserState<'Role, 'ServerId, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_user#home_directory_type-1">TransferUser#home_directory_type</a>.
        /// </summary>
        [<CustomOperation "home_directory_type">]
        member _.HomeDirectoryType(state: TransferUserState<'Role, 'ServerId, 'UserName>, value: string) : TransferUserState<'Role, 'ServerId, 'UserName> =
            state.assignments.Add(fun config -> config.HomeDirectoryType <- value)
            state : TransferUserState<'Role, 'ServerId, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_user#id-1">TransferUser#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: TransferUserState<'Role, 'ServerId, 'UserName>, value: string) : TransferUserState<'Role, 'ServerId, 'UserName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : TransferUserState<'Role, 'ServerId, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_user#policy-1">TransferUser#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: TransferUserState<'Role, 'ServerId, 'UserName>, value: string) : TransferUserState<'Role, 'ServerId, 'UserName> =
            state.assignments.Add(fun config -> config.Policy <- value)
            state : TransferUserState<'Role, 'ServerId, 'UserName>

        /// <summary>
        /// posix_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_user#posix_profile-1">TransferUser#posix_profile</a>
        /// </summary>
        [<CustomOperation "posix_profile">]
        member _.PosixProfile(state: TransferUserState<'Role, 'ServerId, 'UserName>, value: aws.TransferUser.TransferUserPosixProfile) : TransferUserState<'Role, 'ServerId, 'UserName> =
            state.assignments.Add(fun config -> config.PosixProfile <- value)
            state : TransferUserState<'Role, 'ServerId, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_user#tags-1">TransferUser#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: TransferUserState<'Role, 'ServerId, 'UserName>, value: seq<string * string>) : TransferUserState<'Role, 'ServerId, 'UserName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : TransferUserState<'Role, 'ServerId, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_user#tags_all-1">TransferUser#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: TransferUserState<'Role, 'ServerId, 'UserName>, value: seq<string * string>) : TransferUserState<'Role, 'ServerId, 'UserName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : TransferUserState<'Role, 'ServerId, 'UserName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_user#timeouts-1">TransferUser#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: TransferUserState<'Role, 'ServerId, 'UserName>, value: aws.TransferUser.TransferUserTimeouts) : TransferUserState<'Role, 'ServerId, 'UserName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : TransferUserState<'Role, 'ServerId, 'UserName>

        member _.Run(state: TransferUserState<Present, Present, Present>) : aws.TransferUser.TransferUser =
            let config = aws.TransferUser.TransferUserConfig()
            for setter in state.assignments do
                setter config
            aws.TransferUser.TransferUser(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.transferUser: missing required arguments. Must call: role, server_id, user_name.", 9999, IsError = true)>]
        member _.Run(_: TransferUserState<_, _, _>) : aws.TransferUser.TransferUser =
            Unchecked.defaultof<aws.TransferUser.TransferUser>
