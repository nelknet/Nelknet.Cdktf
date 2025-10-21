namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DevopsguruServiceIntegrationState = { assignments: ResizeArray<aws.DevopsguruServiceIntegration.DevopsguruServiceIntegrationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_service_integration">aws_devopsguru_service_integration</a>.
    /// </summary>
    type DevopsguruServiceIntegrationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DevopsguruServiceIntegrationState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DevopsguruServiceIntegrationState =
            { assignments = ResizeArray() }

        /// <summary>
        /// kms_server_side_encryption block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_service_integration#kms_server_side_encryption-1">DevopsguruServiceIntegration#kms_server_side_encryption</a> Accepts: aws.IResolvable | aws.DevopsguruServiceIntegration.DevopsguruServiceIntegrationKmsServerSideEncryption[]
        /// </summary>
        [<CustomOperation "kms_server_side_encryption">]
        member _.KmsServerSideEncryption(state: DevopsguruServiceIntegrationState, value: HashiCorp.Cdktf.IResolvable) : DevopsguruServiceIntegrationState =
            state.assignments.Add(fun config -> config.KmsServerSideEncryption <- value)
            state : DevopsguruServiceIntegrationState

        /// <summary>
        /// logs_anomaly_detection block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_service_integration#logs_anomaly_detection-1">DevopsguruServiceIntegration#logs_anomaly_detection</a> Accepts: aws.IResolvable | aws.DevopsguruServiceIntegration.DevopsguruServiceIntegrationLogsAnomalyDetection[]
        /// </summary>
        [<CustomOperation "logs_anomaly_detection">]
        member _.LogsAnomalyDetection(state: DevopsguruServiceIntegrationState, value: HashiCorp.Cdktf.IResolvable) : DevopsguruServiceIntegrationState =
            state.assignments.Add(fun config -> config.LogsAnomalyDetection <- value)
            state : DevopsguruServiceIntegrationState

        /// <summary>
        /// ops_center block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_service_integration#ops_center-1">DevopsguruServiceIntegration#ops_center</a> Accepts: aws.IResolvable | aws.DevopsguruServiceIntegration.DevopsguruServiceIntegrationOpsCenter[]
        /// </summary>
        [<CustomOperation "ops_center">]
        member _.OpsCenter(state: DevopsguruServiceIntegrationState, value: HashiCorp.Cdktf.IResolvable) : DevopsguruServiceIntegrationState =
            state.assignments.Add(fun config -> config.OpsCenter <- value)
            state : DevopsguruServiceIntegrationState

        member _.Run(state: DevopsguruServiceIntegrationState) : aws.DevopsguruServiceIntegration.DevopsguruServiceIntegration =
            let config = aws.DevopsguruServiceIntegration.DevopsguruServiceIntegrationConfig()
            for setter in state.assignments do
                setter config
            aws.DevopsguruServiceIntegration.DevopsguruServiceIntegration(StackContext.get (), logicalId, config)
