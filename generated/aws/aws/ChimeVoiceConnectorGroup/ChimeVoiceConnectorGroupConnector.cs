using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ChimeVoiceConnectorGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.chimeVoiceConnectorGroup.ChimeVoiceConnectorGroupConnector")]
    public class ChimeVoiceConnectorGroupConnector : aws.ChimeVoiceConnectorGroup.IChimeVoiceConnectorGroupConnector
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_group#priority ChimeVoiceConnectorGroup#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public double Priority
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chime_voice_connector_group#voice_connector_id ChimeVoiceConnectorGroup#voice_connector_id}.</summary>
        [JsiiProperty(name: "voiceConnectorId", typeJson: "{\"primitive\":\"string\"}")]
        public string VoiceConnectorId
        {
            get;
            set;
        }
    }
}
