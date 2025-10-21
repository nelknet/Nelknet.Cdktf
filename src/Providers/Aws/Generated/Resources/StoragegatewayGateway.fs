namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone> = { assignments: ResizeArray<aws.StoragegatewayGateway.StoragegatewayGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway">aws_storagegateway_gateway</a>.
    /// </summary>
    type StoragegatewayGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : StoragegatewayGatewayState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StoragegatewayGatewayState<Missing, Missing>)

        member _.Zero(()) : StoragegatewayGatewayState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StoragegatewayGatewayState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#gateway_name-1">StoragegatewayGateway#gateway_name</a>.
        /// </summary>
        [<CustomOperation "gateway_name">]
        member _.GatewayName(state: StoragegatewayGatewayState<Missing, 'GatewayTimezone>, value: string) : StoragegatewayGatewayState<Present, 'GatewayTimezone> =
            state.assignments.Add(fun config -> config.GatewayName <- value)
            ({ assignments = state.assignments } : StoragegatewayGatewayState<Present, 'GatewayTimezone>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#gateway_timezone-1">StoragegatewayGateway#gateway_timezone</a>.
        /// </summary>
        [<CustomOperation "gateway_timezone">]
        member _.GatewayTimezone(state: StoragegatewayGatewayState<'GatewayName, Missing>, value: string) : StoragegatewayGatewayState<'GatewayName, Present> =
            state.assignments.Add(fun config -> config.GatewayTimezone <- value)
            ({ assignments = state.assignments } : StoragegatewayGatewayState<'GatewayName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#activation_key-1">StoragegatewayGateway#activation_key</a>.
        /// </summary>
        [<CustomOperation "activation_key">]
        member _.ActivationKey(state: StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>, value: string) : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone> =
            state.assignments.Add(fun config -> config.ActivationKey <- value)
            state : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#average_download_rate_limit_in_bits_per_sec-1">StoragegatewayGateway#average_download_rate_limit_in_bits_per_sec</a>.
        /// </summary>
        [<CustomOperation "average_download_rate_limit_in_bits_per_sec">]
        member _.AverageDownloadRateLimitInBitsPerSec(state: StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>, value: double) : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone> =
            state.assignments.Add(fun config -> config.AverageDownloadRateLimitInBitsPerSec <- value)
            state : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#average_upload_rate_limit_in_bits_per_sec-1">StoragegatewayGateway#average_upload_rate_limit_in_bits_per_sec</a>.
        /// </summary>
        [<CustomOperation "average_upload_rate_limit_in_bits_per_sec">]
        member _.AverageUploadRateLimitInBitsPerSec(state: StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>, value: double) : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone> =
            state.assignments.Add(fun config -> config.AverageUploadRateLimitInBitsPerSec <- value)
            state : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#cloudwatch_log_group_arn-1">StoragegatewayGateway#cloudwatch_log_group_arn</a>.
        /// </summary>
        [<CustomOperation "cloudwatch_log_group_arn">]
        member _.CloudwatchLogGroupArn(state: StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>, value: string) : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone> =
            state.assignments.Add(fun config -> config.CloudwatchLogGroupArn <- value)
            state : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#gateway_ip_address-1">StoragegatewayGateway#gateway_ip_address</a>.
        /// </summary>
        [<CustomOperation "gateway_ip_address">]
        member _.GatewayIpAddress(state: StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>, value: string) : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone> =
            state.assignments.Add(fun config -> config.GatewayIpAddress <- value)
            state : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#gateway_type-1">StoragegatewayGateway#gateway_type</a>.
        /// </summary>
        [<CustomOperation "gateway_type">]
        member _.GatewayType(state: StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>, value: string) : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone> =
            state.assignments.Add(fun config -> config.GatewayType <- value)
            state : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#gateway_vpc_endpoint-1">StoragegatewayGateway#gateway_vpc_endpoint</a>.
        /// </summary>
        [<CustomOperation "gateway_vpc_endpoint">]
        member _.GatewayVpcEndpoint(state: StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>, value: string) : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone> =
            state.assignments.Add(fun config -> config.GatewayVpcEndpoint <- value)
            state : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#id-1">StoragegatewayGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>, value: string) : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>

        /// <summary>
        /// maintenance_start_time block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#maintenance_start_time-1">StoragegatewayGateway#maintenance_start_time</a>
        /// </summary>
        [<CustomOperation "maintenance_start_time">]
        member _.MaintenanceStartTime(state: StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>, value: aws.StoragegatewayGateway.StoragegatewayGatewayMaintenanceStartTime) : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone> =
            state.assignments.Add(fun config -> config.MaintenanceStartTime <- value)
            state : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#medium_changer_type-1">StoragegatewayGateway#medium_changer_type</a>.
        /// </summary>
        [<CustomOperation "medium_changer_type">]
        member _.MediumChangerType(state: StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>, value: string) : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone> =
            state.assignments.Add(fun config -> config.MediumChangerType <- value)
            state : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>

        /// <summary>
        /// smb_active_directory_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#smb_active_directory_settings-1">StoragegatewayGateway#smb_active_directory_settings</a>
        /// </summary>
        [<CustomOperation "smb_active_directory_settings">]
        member _.SmbActiveDirectorySettings(state: StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>, value: aws.StoragegatewayGateway.StoragegatewayGatewaySmbActiveDirectorySettings) : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone> =
            state.assignments.Add(fun config -> config.SmbActiveDirectorySettings <- value)
            state : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#smb_file_share_visibility-1">StoragegatewayGateway#smb_file_share_visibility</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "smb_file_share_visibility">]
        member _.SmbFileShareVisibility(state: StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>, value: bool) : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone> =
            state.assignments.Add(fun config -> config.SmbFileShareVisibility <- value)
            state : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#smb_file_share_visibility-1">StoragegatewayGateway#smb_file_share_visibility</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "smb_file_share_visibility">]
        member _.SmbFileShareVisibility(state: StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>, value: HashiCorp.Cdktf.IResolvable) : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone> =
            state.assignments.Add(fun config -> config.SmbFileShareVisibility <- value)
            state : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#smb_guest_password-1">StoragegatewayGateway#smb_guest_password</a>.
        /// </summary>
        [<CustomOperation "smb_guest_password">]
        member _.SmbGuestPassword(state: StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>, value: string) : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone> =
            state.assignments.Add(fun config -> config.SmbGuestPassword <- value)
            state : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#smb_security_strategy-1">StoragegatewayGateway#smb_security_strategy</a>.
        /// </summary>
        [<CustomOperation "smb_security_strategy">]
        member _.SmbSecurityStrategy(state: StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>, value: string) : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone> =
            state.assignments.Add(fun config -> config.SmbSecurityStrategy <- value)
            state : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#tags-1">StoragegatewayGateway#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>, value: seq<string * string>) : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#tags_all-1">StoragegatewayGateway#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>, value: seq<string * string>) : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#tape_drive_type-1">StoragegatewayGateway#tape_drive_type</a>.
        /// </summary>
        [<CustomOperation "tape_drive_type">]
        member _.TapeDriveType(state: StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>, value: string) : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone> =
            state.assignments.Add(fun config -> config.TapeDriveType <- value)
            state : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#timeouts-1">StoragegatewayGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>, value: aws.StoragegatewayGateway.StoragegatewayGatewayTimeouts) : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StoragegatewayGatewayState<'GatewayName, 'GatewayTimezone>

        member _.Run(state: StoragegatewayGatewayState<Present, Present>) : aws.StoragegatewayGateway.StoragegatewayGateway =
            let config = aws.StoragegatewayGateway.StoragegatewayGatewayConfig()
            for setter in state.assignments do
                setter config
            aws.StoragegatewayGateway.StoragegatewayGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.storagegatewayGateway: missing required arguments. Must call: gateway_name, gateway_timezone.", 9999, IsError = true)>]
        member _.Run(_: StoragegatewayGatewayState<_, _>) : aws.StoragegatewayGateway.StoragegatewayGateway =
            Unchecked.defaultof<aws.StoragegatewayGateway.StoragegatewayGateway>
