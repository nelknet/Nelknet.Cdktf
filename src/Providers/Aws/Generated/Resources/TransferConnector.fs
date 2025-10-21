namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type TransferConnectorState<'AccessRole, 'Url> = { assignments: ResizeArray<aws.TransferConnector.TransferConnectorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_connector">aws_transfer_connector</a>.
    /// </summary>
    type TransferConnectorBuilder(logicalId: string) =
        member _.Yield(_: unit) : TransferConnectorState<Missing, Missing> =
            ({ assignments = ResizeArray() } : TransferConnectorState<Missing, Missing>)

        member _.Zero(()) : TransferConnectorState<Missing, Missing> =
            ({ assignments = ResizeArray() } : TransferConnectorState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_connector#access_role-1">TransferConnector#access_role</a>.
        /// </summary>
        [<CustomOperation "access_role">]
        member _.AccessRole(state: TransferConnectorState<Missing, 'Url>, value: string) : TransferConnectorState<Present, 'Url> =
            state.assignments.Add(fun config -> config.AccessRole <- value)
            ({ assignments = state.assignments } : TransferConnectorState<Present, 'Url>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_connector#url-1">TransferConnector#url</a>.
        /// </summary>
        [<CustomOperation "url">]
        member _.Url(state: TransferConnectorState<'AccessRole, Missing>, value: string) : TransferConnectorState<'AccessRole, Present> =
            state.assignments.Add(fun config -> config.Url <- value)
            ({ assignments = state.assignments } : TransferConnectorState<'AccessRole, Present>)

        /// <summary>
        /// as2_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_connector#as2_config-1">TransferConnector#as2_config</a>
        /// </summary>
        [<CustomOperation "as2_config">]
        member _.As2Config(state: TransferConnectorState<'AccessRole, 'Url>, value: aws.TransferConnector.TransferConnectorAs2Config) : TransferConnectorState<'AccessRole, 'Url> =
            state.assignments.Add(fun config -> config.As2Config <- value)
            state : TransferConnectorState<'AccessRole, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_connector#id-1">TransferConnector#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: TransferConnectorState<'AccessRole, 'Url>, value: string) : TransferConnectorState<'AccessRole, 'Url> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : TransferConnectorState<'AccessRole, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_connector#logging_role-1">TransferConnector#logging_role</a>.
        /// </summary>
        [<CustomOperation "logging_role">]
        member _.LoggingRole(state: TransferConnectorState<'AccessRole, 'Url>, value: string) : TransferConnectorState<'AccessRole, 'Url> =
            state.assignments.Add(fun config -> config.LoggingRole <- value)
            state : TransferConnectorState<'AccessRole, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_connector#security_policy_name-1">TransferConnector#security_policy_name</a>.
        /// </summary>
        [<CustomOperation "security_policy_name">]
        member _.SecurityPolicyName(state: TransferConnectorState<'AccessRole, 'Url>, value: string) : TransferConnectorState<'AccessRole, 'Url> =
            state.assignments.Add(fun config -> config.SecurityPolicyName <- value)
            state : TransferConnectorState<'AccessRole, 'Url>

        /// <summary>
        /// sftp_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_connector#sftp_config-1">TransferConnector#sftp_config</a>
        /// </summary>
        [<CustomOperation "sftp_config">]
        member _.SftpConfig(state: TransferConnectorState<'AccessRole, 'Url>, value: aws.TransferConnector.TransferConnectorSftpConfig) : TransferConnectorState<'AccessRole, 'Url> =
            state.assignments.Add(fun config -> config.SftpConfig <- value)
            state : TransferConnectorState<'AccessRole, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_connector#tags-1">TransferConnector#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: TransferConnectorState<'AccessRole, 'Url>, value: seq<string * string>) : TransferConnectorState<'AccessRole, 'Url> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : TransferConnectorState<'AccessRole, 'Url>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_connector#tags_all-1">TransferConnector#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: TransferConnectorState<'AccessRole, 'Url>, value: seq<string * string>) : TransferConnectorState<'AccessRole, 'Url> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : TransferConnectorState<'AccessRole, 'Url>

        member _.Run(state: TransferConnectorState<Present, Present>) : aws.TransferConnector.TransferConnector =
            let config = aws.TransferConnector.TransferConnectorConfig()
            for setter in state.assignments do
                setter config
            aws.TransferConnector.TransferConnector(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.transferConnector: missing required arguments. Must call: access_role, url.", 9999, IsError = true)>]
        member _.Run(_: TransferConnectorState<_, _>) : aws.TransferConnector.TransferConnector =
            Unchecked.defaultof<aws.TransferConnector.TransferConnector>
