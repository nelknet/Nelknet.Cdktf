namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamAccessKeyState<'User> = { assignments: ResizeArray<aws.IamAccessKey.IamAccessKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_access_key">aws_iam_access_key</a>.
    /// </summary>
    type IamAccessKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamAccessKeyState<Missing> =
            ({ assignments = ResizeArray() } : IamAccessKeyState<Missing>)

        member _.Zero(()) : IamAccessKeyState<Missing> =
            ({ assignments = ResizeArray() } : IamAccessKeyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_access_key#user-1">IamAccessKey#user</a>.
        /// </summary>
        [<CustomOperation "user">]
        member _.User(state: IamAccessKeyState<Missing>, value: string) : IamAccessKeyState<Present> =
            state.assignments.Add(fun config -> config.User <- value)
            ({ assignments = state.assignments } : IamAccessKeyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_access_key#id-1">IamAccessKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamAccessKeyState<'User>, value: string) : IamAccessKeyState<'User> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamAccessKeyState<'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_access_key#pgp_key-1">IamAccessKey#pgp_key</a>.
        /// </summary>
        [<CustomOperation "pgp_key">]
        member _.PgpKey(state: IamAccessKeyState<'User>, value: string) : IamAccessKeyState<'User> =
            state.assignments.Add(fun config -> config.PgpKey <- value)
            state : IamAccessKeyState<'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_access_key#status-1">IamAccessKey#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: IamAccessKeyState<'User>, value: string) : IamAccessKeyState<'User> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : IamAccessKeyState<'User>

        member _.Run(state: IamAccessKeyState<Present>) : aws.IamAccessKey.IamAccessKey =
            let config = aws.IamAccessKey.IamAccessKeyConfig()
            for setter in state.assignments do
                setter config
            aws.IamAccessKey.IamAccessKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamAccessKey: missing required arguments. Must call: user.", 9999, IsError = true)>]
        member _.Run(_: IamAccessKeyState<_>) : aws.IamAccessKey.IamAccessKey =
            Unchecked.defaultof<aws.IamAccessKey.IamAccessKey>
