namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsIamUserSshKeyState<'Encoding, 'SshPublicKeyId, 'Username> = { assignments: ResizeArray<aws.DataAwsIamUserSshKey.DataAwsIamUserSshKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_user_ssh_key">aws_iam_user_ssh_key</a>.
    /// </summary>
    type DataAwsIamUserSshKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsIamUserSshKeyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsIamUserSshKeyState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAwsIamUserSshKeyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsIamUserSshKeyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_user_ssh_key#encoding-1">DataAwsIamUserSshKey#encoding</a>.
        /// </summary>
        [<CustomOperation "encoding">]
        member _.Encoding(state: DataAwsIamUserSshKeyState<Missing, 'SshPublicKeyId, 'Username>, value: string) : DataAwsIamUserSshKeyState<Present, 'SshPublicKeyId, 'Username> =
            state.assignments.Add(fun config -> config.Encoding <- value)
            ({ assignments = state.assignments } : DataAwsIamUserSshKeyState<Present, 'SshPublicKeyId, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_user_ssh_key#ssh_public_key_id-1">DataAwsIamUserSshKey#ssh_public_key_id</a>.
        /// </summary>
        [<CustomOperation "ssh_public_key_id">]
        member _.SshPublicKeyId(state: DataAwsIamUserSshKeyState<'Encoding, Missing, 'Username>, value: string) : DataAwsIamUserSshKeyState<'Encoding, Present, 'Username> =
            state.assignments.Add(fun config -> config.SshPublicKeyId <- value)
            ({ assignments = state.assignments } : DataAwsIamUserSshKeyState<'Encoding, Present, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_user_ssh_key#username-1">DataAwsIamUserSshKey#username</a>.
        /// </summary>
        [<CustomOperation "username">]
        member _.Username(state: DataAwsIamUserSshKeyState<'Encoding, 'SshPublicKeyId, Missing>, value: string) : DataAwsIamUserSshKeyState<'Encoding, 'SshPublicKeyId, Present> =
            state.assignments.Add(fun config -> config.Username <- value)
            ({ assignments = state.assignments } : DataAwsIamUserSshKeyState<'Encoding, 'SshPublicKeyId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_user_ssh_key#id-1">DataAwsIamUserSshKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsIamUserSshKeyState<'Encoding, 'SshPublicKeyId, 'Username>, value: string) : DataAwsIamUserSshKeyState<'Encoding, 'SshPublicKeyId, 'Username> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsIamUserSshKeyState<'Encoding, 'SshPublicKeyId, 'Username>

        member _.Run(state: DataAwsIamUserSshKeyState<Present, Present, Present>) : aws.DataAwsIamUserSshKey.DataAwsIamUserSshKey =
            let config = aws.DataAwsIamUserSshKey.DataAwsIamUserSshKeyConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsIamUserSshKey.DataAwsIamUserSshKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsIamUserSshKey: missing required arguments. Must call: encoding, ssh_public_key_id, username.", 9999, IsError = true)>]
        member _.Run(_: DataAwsIamUserSshKeyState<_, _, _>) : aws.DataAwsIamUserSshKey.DataAwsIamUserSshKey =
            Unchecked.defaultof<aws.DataAwsIamUserSshKey.DataAwsIamUserSshKey>
