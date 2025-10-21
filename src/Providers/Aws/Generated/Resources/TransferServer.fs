namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type TransferServerState = { assignments: ResizeArray<aws.TransferServer.TransferServerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server">aws_transfer_server</a>.
    /// </summary>
    type TransferServerBuilder(logicalId: string) =
        member _.Yield(_: unit) : TransferServerState =
            { assignments = ResizeArray() }

        member _.Zero(()) : TransferServerState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#certificate-1">TransferServer#certificate</a>.
        /// </summary>
        [<CustomOperation "certificate">]
        member _.Certificate(state: TransferServerState, value: string) : TransferServerState =
            state.assignments.Add(fun config -> config.Certificate <- value)
            state : TransferServerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#directory_id-1">TransferServer#directory_id</a>.
        /// </summary>
        [<CustomOperation "directory_id">]
        member _.DirectoryId(state: TransferServerState, value: string) : TransferServerState =
            state.assignments.Add(fun config -> config.DirectoryId <- value)
            state : TransferServerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#domain-1">TransferServer#domain</a>.
        /// </summary>
        [<CustomOperation "domain">]
        member _.Domain(state: TransferServerState, value: string) : TransferServerState =
            state.assignments.Add(fun config -> config.Domain <- value)
            state : TransferServerState

        /// <summary>
        /// endpoint_details block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#endpoint_details-1">TransferServer#endpoint_details</a>
        /// </summary>
        [<CustomOperation "endpoint_details">]
        member _.EndpointDetails(state: TransferServerState, value: aws.TransferServer.TransferServerEndpointDetails) : TransferServerState =
            state.assignments.Add(fun config -> config.EndpointDetails <- value)
            state : TransferServerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#endpoint_type-1">TransferServer#endpoint_type</a>.
        /// </summary>
        [<CustomOperation "endpoint_type">]
        member _.EndpointType(state: TransferServerState, value: string) : TransferServerState =
            state.assignments.Add(fun config -> config.EndpointType <- value)
            state : TransferServerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#force_destroy-1">TransferServer#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: TransferServerState, value: bool) : TransferServerState =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : TransferServerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#force_destroy-1">TransferServer#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: TransferServerState, value: HashiCorp.Cdktf.IResolvable) : TransferServerState =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : TransferServerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#function-1">TransferServer#function</a>.
        /// </summary>
        [<CustomOperation "function">]
        member _.Function(state: TransferServerState, value: string) : TransferServerState =
            state.assignments.Add(fun config -> config.Function <- value)
            state : TransferServerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#host_key-1">TransferServer#host_key</a>.
        /// </summary>
        [<CustomOperation "host_key">]
        member _.HostKey(state: TransferServerState, value: string) : TransferServerState =
            state.assignments.Add(fun config -> config.HostKey <- value)
            state : TransferServerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#id-1">TransferServer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: TransferServerState, value: string) : TransferServerState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : TransferServerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#identity_provider_type-1">TransferServer#identity_provider_type</a>.
        /// </summary>
        [<CustomOperation "identity_provider_type">]
        member _.IdentityProviderType(state: TransferServerState, value: string) : TransferServerState =
            state.assignments.Add(fun config -> config.IdentityProviderType <- value)
            state : TransferServerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#invocation_role-1">TransferServer#invocation_role</a>.
        /// </summary>
        [<CustomOperation "invocation_role">]
        member _.InvocationRole(state: TransferServerState, value: string) : TransferServerState =
            state.assignments.Add(fun config -> config.InvocationRole <- value)
            state : TransferServerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#logging_role-1">TransferServer#logging_role</a>.
        /// </summary>
        [<CustomOperation "logging_role">]
        member _.LoggingRole(state: TransferServerState, value: string) : TransferServerState =
            state.assignments.Add(fun config -> config.LoggingRole <- value)
            state : TransferServerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#post_authentication_login_banner-1">TransferServer#post_authentication_login_banner</a>.
        /// </summary>
        [<CustomOperation "post_authentication_login_banner">]
        member _.PostAuthenticationLoginBanner(state: TransferServerState, value: string) : TransferServerState =
            state.assignments.Add(fun config -> config.PostAuthenticationLoginBanner <- value)
            state : TransferServerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#pre_authentication_login_banner-1">TransferServer#pre_authentication_login_banner</a>.
        /// </summary>
        [<CustomOperation "pre_authentication_login_banner">]
        member _.PreAuthenticationLoginBanner(state: TransferServerState, value: string) : TransferServerState =
            state.assignments.Add(fun config -> config.PreAuthenticationLoginBanner <- value)
            state : TransferServerState

        /// <summary>
        /// protocol_details block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#protocol_details-1">TransferServer#protocol_details</a>
        /// </summary>
        [<CustomOperation "protocol_details">]
        member _.ProtocolDetails(state: TransferServerState, value: aws.TransferServer.TransferServerProtocolDetails) : TransferServerState =
            state.assignments.Add(fun config -> config.ProtocolDetails <- value)
            state : TransferServerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#protocols-1">TransferServer#protocols</a>.
        /// </summary>
        [<CustomOperation "protocols">]
        member _.Protocols(state: TransferServerState, value: seq<string>) : TransferServerState =
            state.assignments.Add(fun config -> config.Protocols <- (value |> Seq.toArray))
            state : TransferServerState

        /// <summary>
        /// s3_storage_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#s3_storage_options-1">TransferServer#s3_storage_options</a>
        /// </summary>
        [<CustomOperation "s3_storage_options">]
        member _.S3StorageOptions(state: TransferServerState, value: aws.TransferServer.TransferServerS3StorageOptions) : TransferServerState =
            state.assignments.Add(fun config -> config.S3StorageOptions <- value)
            state : TransferServerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#security_policy_name-1">TransferServer#security_policy_name</a>.
        /// </summary>
        [<CustomOperation "security_policy_name">]
        member _.SecurityPolicyName(state: TransferServerState, value: string) : TransferServerState =
            state.assignments.Add(fun config -> config.SecurityPolicyName <- value)
            state : TransferServerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#sftp_authentication_methods-1">TransferServer#sftp_authentication_methods</a>.
        /// </summary>
        [<CustomOperation "sftp_authentication_methods">]
        member _.SftpAuthenticationMethods(state: TransferServerState, value: string) : TransferServerState =
            state.assignments.Add(fun config -> config.SftpAuthenticationMethods <- value)
            state : TransferServerState

        /// <summary>
        /// This is a set of arns of destinations that will receive structured logs from the transfer server. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#structured_log_destinations-1">TransferServer#structured_log_destinations</a>
        /// </summary>
        [<CustomOperation "structured_log_destinations">]
        member _.StructuredLogDestinations(state: TransferServerState, value: seq<string>) : TransferServerState =
            state.assignments.Add(fun config -> config.StructuredLogDestinations <- (value |> Seq.toArray))
            state : TransferServerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#tags-1">TransferServer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: TransferServerState, value: seq<string * string>) : TransferServerState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : TransferServerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#tags_all-1">TransferServer#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: TransferServerState, value: seq<string * string>) : TransferServerState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : TransferServerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#url-1">TransferServer#url</a>.
        /// </summary>
        [<CustomOperation "url">]
        member _.Url(state: TransferServerState, value: string) : TransferServerState =
            state.assignments.Add(fun config -> config.Url <- value)
            state : TransferServerState

        /// <summary>
        /// workflow_details block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#workflow_details-1">TransferServer#workflow_details</a>
        /// </summary>
        [<CustomOperation "workflow_details">]
        member _.WorkflowDetails(state: TransferServerState, value: aws.TransferServer.TransferServerWorkflowDetails) : TransferServerState =
            state.assignments.Add(fun config -> config.WorkflowDetails <- value)
            state : TransferServerState

        member _.Run(state: TransferServerState) : aws.TransferServer.TransferServer =
            let config = aws.TransferServer.TransferServerConfig()
            for setter in state.assignments do
                setter config
            aws.TransferServer.TransferServer(StackContext.get (), logicalId, config)
