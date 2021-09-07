import axios from "axios";

export default axios.create({
  baseURL: "mysql://b01c6a16a2cb9d:586edf03@us-cdbr-east-04.cleardb.com/heroku_c1f9fd03d63a564?reconnect=true",
  headers: {
    "Content-type": "application/json"
  }
});