namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecuritylakeAwsLogSourceState = { assignments: ResizeArray<aws.SecuritylakeAwsLogSource.SecuritylakeAwsLogSourceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_aws_log_source">aws_securitylake_aws_log_source</a>.
    /// </summary>
    type SecuritylakeAwsLogSourceBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecuritylakeAwsLogSourceState =
            { assignments = ResizeArray() }

        member _.Zero(()) : SecuritylakeAwsLogSourceState =
            { assignments = ResizeArray() }

        /// <summary>
        /// source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_aws_log_source#source-1">SecuritylakeAwsLogSource#source</a> Accepts: aws.IResolvable | aws.SecuritylakeAwsLogSource.SecuritylakeAwsLogSourceSource[]
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: SecuritylakeAwsLogSourceState, value: HashiCorp.Cdktf.IResolvable) : SecuritylakeAwsLogSourceState =
            state.assignments.Add(fun config -> config.Source <- value)
            state : SecuritylakeAwsLogSourceState

        member _.Run(state: SecuritylakeAwsLogSourceState) : aws.SecuritylakeAwsLogSource.SecuritylakeAwsLogSource =
            let config = aws.SecuritylakeAwsLogSource.SecuritylakeAwsLogSourceConfig()
            for setter in state.assignments do
                setter config
            aws.SecuritylakeAwsLogSource.SecuritylakeAwsLogSource(StackContext.get (), logicalId, config)
