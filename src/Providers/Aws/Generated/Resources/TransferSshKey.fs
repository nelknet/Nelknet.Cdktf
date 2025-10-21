namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type TransferSshKeyState<'Body, 'ServerId, 'UserName> = { assignments: ResizeArray<aws.TransferSshKey.TransferSshKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_ssh_key">aws_transfer_ssh_key</a>.
    /// </summary>
    type TransferSshKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : TransferSshKeyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : TransferSshKeyState<Missing, Missing, Missing>)

        member _.Zero(()) : TransferSshKeyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : TransferSshKeyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_ssh_key#body-1">TransferSshKey#body</a>.
        /// </summary>
        [<CustomOperation "body">]
        member _.Body(state: TransferSshKeyState<Missing, 'ServerId, 'UserName>, value: string) : TransferSshKeyState<Present, 'ServerId, 'UserName> =
            state.assignments.Add(fun config -> config.Body <- value)
            ({ assignments = state.assignments } : TransferSshKeyState<Present, 'ServerId, 'UserName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_ssh_key#server_id-1">TransferSshKey#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: TransferSshKeyState<'Body, Missing, 'UserName>, value: string) : TransferSshKeyState<'Body, Present, 'UserName> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            ({ assignments = state.assignments } : TransferSshKeyState<'Body, Present, 'UserName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_ssh_key#user_name-1">TransferSshKey#user_name</a>.
        /// </summary>
        [<CustomOperation "user_name">]
        member _.UserName(state: TransferSshKeyState<'Body, 'ServerId, Missing>, value: string) : TransferSshKeyState<'Body, 'ServerId, Present> =
            state.assignments.Add(fun config -> config.UserName <- value)
            ({ assignments = state.assignments } : TransferSshKeyState<'Body, 'ServerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_ssh_key#id-1">TransferSshKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: TransferSshKeyState<'Body, 'ServerId, 'UserName>, value: string) : TransferSshKeyState<'Body, 'ServerId, 'UserName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : TransferSshKeyState<'Body, 'ServerId, 'UserName>

        member _.Run(state: TransferSshKeyState<Present, Present, Present>) : aws.TransferSshKey.TransferSshKey =
            let config = aws.TransferSshKey.TransferSshKeyConfig()
            for setter in state.assignments do
                setter config
            aws.TransferSshKey.TransferSshKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.transferSshKey: missing required arguments. Must call: body, server_id, user_name.", 9999, IsError = true)>]
        member _.Run(_: TransferSshKeyState<_, _, _>) : aws.TransferSshKey.TransferSshKey =
            Unchecked.defaultof<aws.TransferSshKey.TransferSshKey>
