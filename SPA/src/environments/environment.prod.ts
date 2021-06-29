
const SYSTEM_CODE = 3;
export const environment = {
  production: true,
  systemCode: SYSTEM_CODE,
  apiUrlEC: '/api/',
  apiUrl: 'http://10.4.5.174:108/api/',
  apiUrl2: 'http://10.4.5.174:108/api/',
  hub: '/ec-hub',
  scalingHub: 'http://localhost:5001/ec-hub',
  scalingHubLocal: 'http://localhost:5001/scalingHub',
  _mqtt: {
    server: 'mqtt.myweb.com',
    protocol: "wss",
    port: 1883
  },
  get mqtt() {
    return this._mqtt;
  },
  set mqtt(value) {
    this._mqtt = value;
  },
};