namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamUserSshKeyState<'Encoding, 'PublicKey, 'Username> = { assignments: ResizeArray<aws.IamUserSshKey.IamUserSshKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_ssh_key">aws_iam_user_ssh_key</a>.
    /// </summary>
    type IamUserSshKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamUserSshKeyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IamUserSshKeyState<Missing, Missing, Missing>)

        member _.Zero(()) : IamUserSshKeyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IamUserSshKeyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_ssh_key#encoding-1">IamUserSshKey#encoding</a>.
        /// </summary>
        [<CustomOperation "encoding">]
        member _.Encoding(state: IamUserSshKeyState<Missing, 'PublicKey, 'Username>, value: string) : IamUserSshKeyState<Present, 'PublicKey, 'Username> =
            state.assignments.Add(fun config -> config.Encoding <- value)
            ({ assignments = state.assignments } : IamUserSshKeyState<Present, 'PublicKey, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_ssh_key#public_key-1">IamUserSshKey#public_key</a>.
        /// </summary>
        [<CustomOperation "public_key">]
        member _.PublicKey(state: IamUserSshKeyState<'Encoding, Missing, 'Username>, value: string) : IamUserSshKeyState<'Encoding, Present, 'Username> =
            state.assignments.Add(fun config -> config.PublicKey <- value)
            ({ assignments = state.assignments } : IamUserSshKeyState<'Encoding, Present, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_ssh_key#username-1">IamUserSshKey#username</a>.
        /// </summary>
        [<CustomOperation "username">]
        member _.Username(state: IamUserSshKeyState<'Encoding, 'PublicKey, Missing>, value: string) : IamUserSshKeyState<'Encoding, 'PublicKey, Present> =
            state.assignments.Add(fun config -> config.Username <- value)
            ({ assignments = state.assignments } : IamUserSshKeyState<'Encoding, 'PublicKey, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_ssh_key#id-1">IamUserSshKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamUserSshKeyState<'Encoding, 'PublicKey, 'Username>, value: string) : IamUserSshKeyState<'Encoding, 'PublicKey, 'Username> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamUserSshKeyState<'Encoding, 'PublicKey, 'Username>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_user_ssh_key#status-1">IamUserSshKey#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: IamUserSshKeyState<'Encoding, 'PublicKey, 'Username>, value: string) : IamUserSshKeyState<'Encoding, 'PublicKey, 'Username> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : IamUserSshKeyState<'Encoding, 'PublicKey, 'Username>

        member _.Run(state: IamUserSshKeyState<Present, Present, Present>) : aws.IamUserSshKey.IamUserSshKey =
            let config = aws.IamUserSshKey.IamUserSshKeyConfig()
            for setter in state.assignments do
                setter config
            aws.IamUserSshKey.IamUserSshKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamUserSshKey: missing required arguments. Must call: encoding, public_key, username.", 9999, IsError = true)>]
        member _.Run(_: IamUserSshKeyState<_, _, _>) : aws.IamUserSshKey.IamUserSshKey =
            Unchecked.defaultof<aws.IamUserSshKey.IamUserSshKey>
