namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Macie2ClassificationExportConfigurationState = { assignments: ResizeArray<aws.Macie2ClassificationExportConfiguration.Macie2ClassificationExportConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_export_configuration">aws_macie2_classification_export_configuration</a>.
    /// </summary>
    type Macie2ClassificationExportConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Macie2ClassificationExportConfigurationState =
            { assignments = ResizeArray() }

        member _.Zero(()) : Macie2ClassificationExportConfigurationState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_export_configuration#id-1">Macie2ClassificationExportConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Macie2ClassificationExportConfigurationState, value: string) : Macie2ClassificationExportConfigurationState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Macie2ClassificationExportConfigurationState

        /// <summary>
        /// s3_destination block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_export_configuration#s3_destination-1">Macie2ClassificationExportConfiguration#s3_destination</a>
        /// </summary>
        [<CustomOperation "s3_destination">]
        member _.S3Destination(state: Macie2ClassificationExportConfigurationState, value: aws.Macie2ClassificationExportConfiguration.Macie2ClassificationExportConfigurationS3Destination) : Macie2ClassificationExportConfigurationState =
            state.assignments.Add(fun config -> config.S3Destination <- value)
            state : Macie2ClassificationExportConfigurationState

        member _.Run(state: Macie2ClassificationExportConfigurationState) : aws.Macie2ClassificationExportConfiguration.Macie2ClassificationExportConfiguration =
            let config = aws.Macie2ClassificationExportConfiguration.Macie2ClassificationExportConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.Macie2ClassificationExportConfiguration.Macie2ClassificationExportConfiguration(StackContext.get (), logicalId, config)
